using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace test_3
{
    public partial class BaiduSpider : Form
    {
        private Boolean IsStop = false;
        public BaiduSpider()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c_color.SelectedIndex = 0;
            c_size.SelectedIndex = 0;
            c_type.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bth_selectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择文件夹保存文件！";
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;
            //folderBrowserDialog.ShowDialog();

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                t_savePath.Text = folderBrowserDialog.SelectedPath;
            }

        }

        private void t_savePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void bth_download_Click(object sender, EventArgs e)
        {
            //Stream stream = Download.DownloadFile("https://image.baidu.com/");
            //using (StreamReader sr = new StreamReader(stream))
            //{
            //  textBox1.Text = sr.ReadToEnd();
            // }
            //return;
            if (bth_download.Text == "开始下载")
            {

                if (String.IsNullOrEmpty(t_keyword.Text))
                {
                    MessageBox.Show("关键词为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrEmpty(t_savePath.Text))
                {
                    MessageBox.Show("保存路径为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Directory.Exists(t_savePath.Text))
                {
                    try
                    {
                        Directory.CreateDirectory(t_savePath.Text);
                    }
                    catch
                    {
                        MessageBox.Show("创建路径失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                try
                {
                    using (FileStream fs = new FileStream(Path.Combine(t_savePath.Text, "Test_File.txt"), FileMode.Create)) ;
                    File.Delete(Path.Combine(t_savePath.Text, "Test_File.txt"));
                }
                catch
                {
                    MessageBox.Show("文件不可写入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //下载过程
                //t_Logs.Text = Geturl();
                String Url = Geturl();
                Thread thread = new Thread(() => { Downloads(Url, (int)n_page.Value); });
                IsStop = false;
                thread.Start();

                bth_download.Text = "停止下载";
            }
            else
            {
                IsStop = true;
            }
            
            

        }
        private void Downloads(String url,int Pages)
        {
            int number = 0;
            
            //int Pages =(int) n_page.Value;
            for (int i = 0; i < Pages; i++)
            {
                if (IsStop)
                    break;

                int nums = 0, times = 0;
                String Url = url.Replace("[REPLACE]", (50 * i).ToString());
                Stream stream = null;
                try
                {
                    stream = Download.DownloadFile(Url);
                }
                catch
                {
                    continue;
                }
                String Html;
                try
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        Html = sr.ReadToEnd();
                    }
                    //t_Logs.Text = Html;
                }
                catch
                {
                    continue;
                }

                
                JObject jobj = JObject.Parse(Html);
                JArray jarr = (JArray)jobj["data"];

                while (nums < 50 && times <10)
                {
                    times++;
                    for (int j = 0; j < jarr.Count; j++)
                    {
                        if (IsStop)
                            break;
                        try
                        {

                            String PicUrl = jarr[j]["thumbURL"].ToString();
                            String SavePath = Path.Combine(t_savePath.Text, ReName(PicUrl.Substring(PicUrl.LastIndexOf("/") + 1)));
                            String PicReferer = "http://image.baidu.com/";
                            //t_Logs.Text += (PicUrl) + Environment.NewLine;
                            //t_Logs.Text += (SavePath) + Environment.NewLine;
                            SavePath = Path.Combine(t_savePath.Text, ReName(PicUrl.Substring(PicUrl.LastIndexOf("/") + 1)));
                            if (jarr[j].ToString().Contains("replaceUrl"))
                            {
                                PicUrl = jarr[j]["replaceUrl"][0]["ObjURL"].ToString();
                                SavePath = Path.Combine(t_savePath.Text, ReName(PicUrl.Substring(PicUrl.LastIndexOf("/") + 1)));
                                PicReferer = jarr[j]["replaceUrl"][0]["FromURL"].ToString();
                            }
                            if (File.Exists(SavePath))
                            {
                                continue;
                            }
                            if (Download.DownloadFile(PicUrl, SavePath, PicReferer))
                            {
                                this.Invoke(new Action(() =>
                                {
                                    nums++;
                                    t_Logs.Text += String.Format("图片{0}下载成功", PicUrl.Substring(PicUrl.LastIndexOf("/") + 1)) + Environment.NewLine;
                                }));
                                number++;


                            }
                            else
                            {
                                this.Invoke(new Action(() =>
                                {
                                    t_Logs.Text += String.Format("图片{0}下载失败", PicUrl.Substring(PicUrl.LastIndexOf("/") + 1)) + Environment.NewLine;
                                }));
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
            this.Invoke(new Action(() => {
                bth_download.Text = "开始下载";
            }));
            this.Invoke(new Action(() => {
                t_Logs.Text += "已下载图片" + number + "张";
            }));
        }
        private String ReName(String FileAddress)
        {
            FileAddress = FileAddress.Replace(":","_");
            FileAddress = FileAddress.Replace("*", "_");
            FileAddress = FileAddress.Replace("?", "_");
            FileAddress = FileAddress.Replace("\\", "_");
            FileAddress = FileAddress.Replace("/", "_");
            FileAddress = FileAddress.Replace("\"", "_");
            FileAddress = FileAddress.Replace("<", "_");
            FileAddress = FileAddress.Replace("|", "_");
            FileAddress = FileAddress.Replace(">", "_");
            FileAddress = FileAddress.Replace(" ", "_");
            return FileAddress;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_manual.Checked)
            {
                c_size.Enabled = false;
                c_width.Enabled = true;
                c_height.Enabled = true;
            }
            else
            {
                c_size.Enabled = true;
                c_width.Enabled = false;
                c_height.Enabled = false;
            }
        }
        private String Geturl()
        {
            String queryWord, word;
            queryWord = word = UrlEncode(t_keyword.Text);

            String z;
            z = new String[] { "", "1", "2", "3", "9" }[c_size.SelectedIndex];

            String ic = "";
            if (c_color.SelectedIndex != 0)
                ic = Convert.ToString(Math.Pow(2, c_color.SelectedIndex - 1));

            String st, s, face, lm;
            st = "-1";
            s = face = lm = "";
            switch (c_type.SelectedIndex)
            {
                case 1:
                    s = "1";
                    break;
                case 2:
                    face = "1";
                    break;
                case 3:
                     st = "1";
                    break;
                case 4:
                    st = "2";
                    break;
                case 5:
                    lm = "6";
                    break;
                case 6:
                    lm = "7";
                    break;
                   
            }


            String width, height;
            width = height = "";
            if (c_manual.Checked)
            {
                width = c_width.Value.ToString();
                height = c_height.Value.ToString();
            }
            String Url = String.Format("https://image.baidu.com/search/acjson?tn=resultjson_com&logid=6628973127259823743&ipn=rj&ct=201326592&is=&fp=result&queryWord={0}&cl=2&lm={1}&ie=utf-8&oe=utf-8&adpicid=&st={2}&z={3}&ic={4}&hd=0&latest=0&copyright=0&word={5}&s={6}&se=&tab=&width={7}&height={8}&face={9}&istype=2&qc=&nc=&fr=&expermode=&force=&pn=[REPLACE]&rn=50&gsm=8&1622104661901="
,queryWord,lm,st,z,ic,word,s,width,height,face);
            return Url;
            
            
        }
        private String UrlEncode(String str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(str);
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }
            return (sb.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.t_Logs.Select(this.t_Logs.TextLength, 0);
            this.t_Logs.ScrollToCaret();
        }

        private void BaiduSpider_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsStop = true;
        }

        private void t_keyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void c_width_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
