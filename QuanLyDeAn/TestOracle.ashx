<%@ WebHandler Language="C#" Class="Handler1" %>
<%@ Assembly Name="System.Data.OracleClient, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" %>

using System;
using System.Data.OracleClient;
using System.Web;

public class Handler1 : IHttpHandler
{
    private static readonly string m_User = "USER";
    private static readonly string m_Password = "PASSWORD";
    private static readonly string m_Host = "HOST";

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";

        string result = TestOracleConnection();
        context.Response.Write(result);
    }

    public bool IsReusable
    {
        get { return false; }
    }

    private string TestOracleConnection()
    {
        string result = IntPtr.Size == 8 ?
            "[Running as 64-bit]" : "[Running as 32-bit]";

        try
        {
            string connString = String.Format(
              "Data Source={0};Password={1};User ID={2};",
              m_Host, m_User, m_Password);

            OracleConnection oradb = new OracleConnection();
            oradb.ConnectionString = connString;
            oradb.Open();
            oradb.Close();
            result += " Connection succeeded.";
        }
        catch
        {
            result += " Connection failed.";
        }

        return result;
    }
}