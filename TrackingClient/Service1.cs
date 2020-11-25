using ClosedXML.Excel;
using CsvHelper;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TrackingClient.Models;
using TrackingClient.ViewModels;

namespace TrackingClient
{
    public partial class Service1 : ServiceBase
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
         public static string PSMMSDBEntitiesConnection = System.Configuration.ConfigurationManager.ConnectionStrings["PSMMSDBEntities"].ConnectionString;
      
        PSMMSDBEntities db = new PSMMSDBEntities();
        Timer _timer;
        public Service1()
        {
            _timer = new Timer();
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            System.Diagnostics.Debugger.Launch();
            log.Info("Service is started at " + DateTime.Now);
            _timer.Interval = 24 * 60 * 60 * 1000;
            _timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            _timer.Enabled = true;
            System.Threading.ThreadPool.QueueUserWorkItem(async (_) => await GenerateClientStatement());
        }
        private async void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            //here call api
            await GenerateClientStatement();
        }
        private async Task GenerateClientStatement()
        {
            try
            {

                var Query =  (from c in db.Customers
                             join mr in db.MeterReads
                             on c.ID equals mr.ClientID 
                             select new ClientTracking
                            {
                                 T_NIF = c.NIF,
                                 T_DIRECCION = c.Address,
                                 T_BALANCE = db.MeterReads.Where(x => x.ClientID == c.ID).OrderByDescending(x => x.ID).FirstOrDefault() != null ?
                                 db.MeterReads.Where(x => x.ClientID == c.ID).OrderByDescending(x => x.ID).FirstOrDefault().TotalBalance : 0,
                                 T_NOMBRE = c.Name,
                                 T_MeterNumber = c.MeterNumber,
                                 T_TELEFONO = "34" + c.Phone

                             }).Distinct().ToList();



                var path1 = "C:\\GTServer\\System\\TrackingClientSpain\\TrackingClient" + DateTime.Now.ToString("MM-dd-yyyy") + ".csv";
                if (!File.Exists(path1))
                {
                    var f = File.Create(path1);
                    f.Close();
                    f.Dispose();
                }
                else
                {
                    File.Delete(path1);
                    var f = File.Create(path1);
                    f.Close();
                    f.Dispose();
                }

                //var path1 = "C:\\GTServer\\System\\TrackingClientSpain\\TrackingClient" + DateTime.Now.ToString("MM-dd-yyyy") + ".csv";
                //if (!File.Exists(path1))
                //{
                //    var f=File.Create(path1);
                //    f.Close();
                //}
                //else
                //{
                //    File.Delete(path1);
                //    var f = File.Create(path1);
                //    f.Close();
                //}
                //using (var writer = new StreamWriter(path1))
                //using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                //{

                //    using (var dt = new DataTable())
                //    {
                //        dt.Columns.Add("T_NIF");
                //        dt.Columns.Add("T_DIRECCION");
                //        dt.Columns.Add("T_BALANCE");
                //        dt.Columns.Add("T_NOMBRE");
                //        dt.Columns.Add("T_MeterNumber");
                //        dt.Columns.Add("T_TELEFONO");
                //        foreach (DataColumn column in dt.Columns)
                //        {
                //            csv.WriteField(column.ColumnName);
                //        }
                //        csv.NextRecord();
                //        foreach (var item in Query)
                //        {

                //            var dr = dt.NewRow();
                //            dr["T_NIF"] = item.T_NIF;
                //            dr["T_DIRECCION"] = item.T_DIRECCION.Replace('"', ' ');
                //            dr["T_BALANCE"] = item.T_BALANCE;
                //            dr["T_NOMBRE"] = item.T_NOMBRE;
                //            dr["T_MeterNumber"] = item.T_MeterNumber;
                //            dr["T_TELEFONO"] = item.T_TELEFONO;
                //            dt.Rows.Add(dr);
                //        }
                //        foreach (DataRow row in dt.Rows)
                //        {
                //            for (var i = 0; i < dt.Columns.Count; i++)
                //            {
                //                if (dt.Columns[i].ColumnName != "T_DIRECCION")
                //                {
                //                    csv.Configuration.Delimiter = ";";
                //                }


                //                csv.WriteField(row[i]);
                //            }



                //            csv.NextRecord();
                //        }
                //    }
                //    //csv.Configuration.ShouldQuote = (field, context) =>
                //    //{
                //    //    return false;
                //    //};
                //}



                using (StreamWriter DestinationFile = new StreamWriter(path1, true))
                {
                    DestinationFile.WriteLine("T_NIF" + ";" + "T_DIRECCION" + ";" + "T_BALANCE" + ";" + "T_NOMBRE" + ";" + "T_MeterNumber" + ";" + "T_TELEFONO" + ";");
                    foreach (var item in Query)
                    {
                        DestinationFile.WriteLine(item.T_NIF + ";" + item.T_DIRECCION + ";" + item.T_BALANCE + ";" + item.T_NOMBRE + ";" + item.T_MeterNumber + ";" + item.T_TELEFONO + ";");
                    }
                }

                //string createText = "T_NIF" + "," + "T_DIRECCION" + "," + "T_BALANCE" + "," + "T_NOMBRE" + "," + "T_MeterNumber" + "," + "T_TELEFONO" + "," + Environment.NewLine;
                //File.WriteAllText(path1, createText);
                //foreach (var item in Query)
                //{
                //    string appendText = item.T_NIF + "," + item.T_DIRECCION + "," + item.T_BALANCE + "," + item.T_NOMBRE + "," + item.T_MeterNumber + "," + item.T_TELEFONO + "," + Environment.NewLine;
                //    File.AppendAllText(path1, appendText);
                //}
            }
            catch (Exception e)
            {
                log.Error(e + "\r\n-----------------------------------------------");
                log.Error(e.StackTrace + "\r\n-----------------------------------------------");
            }
        }
        protected override void OnStop()
        {
            log.Info("Service is stopped at " + DateTime.Now);
        }
         
    }
}
