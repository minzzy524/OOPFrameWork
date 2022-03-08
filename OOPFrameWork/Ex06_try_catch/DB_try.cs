using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_try_catch
{
    class DB_try
    {
        /*

                       string constr=@"server=it10-01\sqlexpress;databse=pubs;uid=sa;pwd=knit";
                    SqlConnection conn = new SqlConnection(constr);
                    string sql = "select * from titles";
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = sql;
                    comm.Connection = conn;
                    conn.Open();
                    Console.WriteLine(conn.State);
                    try
                    {
                        SqlDataReader dr = comm.ExecuteReader();
                        while (dr.Read())
                        {
                            Console.WriteLine("{0} - {1} - {2} - {3}", dr["title_id"], dr["title"], dr["type"], dr[16]);
                        }
                        dr.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.Source);
                    }
                    finally
        // 예외가 발생하던, 예외가 발생하지 않던 강제적으로 수행되는 블록(DB)
                    {
                        conn.Close(); // DB연결 해제

                        Console.WriteLine(conn.State);

                    }


        */
    }
}
