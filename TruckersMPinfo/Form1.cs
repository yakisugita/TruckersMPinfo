using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckersMPinfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			if (!System.IO.File.Exists("./settings.ini"))
			{
				System.IO.File.Create("./settings.ini");
			}

			var path = new IniFile(System.IO.Directory.GetCurrentDirectory() + @"\settings.ini");
			filePath.Text = path.GetString("settings", "softalk_path", "");
		}

        private void openbutton_Click(object sender, EventArgs e)
        {
			if (openFileDialog_softalk.ShowDialog() == DialogResult.OK)
			{
				filePath.Text = openFileDialog_softalk.FileName;
			}
		}

        private async void info_Click(object sender, EventArgs e)
        {
            try
            {
				using (var httpclient = new HttpClient())
				{
					var response = await httpclient.GetAsync($"https://api.truckyapp.com/v2/traffic/top?game={game_text.Text}&server={server_text.Text}"); // GET
					JObject response_json = JObject.Parse(response.Content.ReadAsStringAsync().Result); // 取得した情報をjsonオブジェクトに変換

					string calais = response_json["response"][0]["players"].ToString();
					string cd = response_json["response"][1]["players"].ToString();
					string duisburg_ic = response_json["response"][2]["players"].ToString();
					string duisburg = response_json["response"][3]["players"].ToString();

					if (filePath.Text != "")
					{
						string word_1 = $"交通情報をお知らせします。現在シーディールートでは{cd}台、デュースブルク交差点付近では{duisburg_ic}台のトラックが走行中です。";
						string word_2 = $"続いて市内の情報です。デュースブルクでは{duisburg}台、カレーでは{calais}台が走行しています。今日も安全運転でお過ごしください。交通情報でした。";
						ProcessStartInfo processStartInfo = new ProcessStartInfo(filePath.Text, "/X:1 /W:" + word_1 + word_2);
						Process.Start(processStartInfo);
						MessageBox.Show(word_1 + word_2);
					}
				}
			}
            catch (Exception)
            {
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
			var path = new IniFile(System.IO.Directory.GetCurrentDirectory() + @"\settings.ini");
			path.WriteString("settings", "softalk_path", filePath.Text);
		}
    }

    public class IniFile
	{
		[DllImport("kernel32.dll")]
		private static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, uint nSize, string lpFileName);

		[DllImport("kernel32.dll")]
		private static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

		/// Ini ファイルのファイルパス
		public string FilePath { get; set; }

		/// インスタンスの初期化
		public IniFile(string filePath)
		{
			FilePath = filePath;
		}
		/// Ini ファイルから文字列を取得
		public string GetString(string section, string key, string defaultValue = "")
		{
			var sb = new StringBuilder(1024);
			var r = GetPrivateProfileString(section, key, defaultValue, sb, (uint)sb.Capacity, FilePath);
			return sb.ToString();
		}
		/// Ini ファイルに文字列を書き込み
		public bool WriteString(string section, string key, string value)
		{
			return WritePrivateProfileString(section, key, value, FilePath);
		}
	}
}
