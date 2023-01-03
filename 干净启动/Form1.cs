using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.ServiceProcess;

namespace 干净启动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        private void btn_service_disabled_Click(object sender, EventArgs e)
        {
            var lst_services = ServiceController.GetServices().ToList();
            foreach (var service in lst_services)
            {
                // 这里要保存原先的状态
                var strs = lst_services.Select(x => x.DisplayName).ToArray();
                var str = string.Join(Environment.NewLine, strs);
                txt_log.Text = str;
            }
        }
    }
}
