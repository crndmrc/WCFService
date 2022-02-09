using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetName(int _id)
	{
		return "ceren";
	}
	public DataTable GetTable()
    {
		DataTable dt = new DataTable();
		Execute _execute = new Execute();
		string _hataMesaji = "";
		dt=_execute.executeDT("select * from TBL_MUSTERI", null, false, ref _hataMesaji);
		dt.TableName = "dtTable";
		return dt;
    }
}
