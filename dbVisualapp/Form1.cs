using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace dbVisualapp
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        string[] lastQueryText;
        string[] lastResultText;
        string[] templastQueryText;
        string[] templastResultText;
        string[] s;
        string[] res;
        int lastact = -1;
        static string server = ""; //localhost
        static string port = ""; //3306 for mysql -> XAMPP
        static string database = ""; //movies
        static string uid = ""; //admin
        static string password = ""; //123456
        static string connectionType = ""; //sql or mysql
        static string sqlconnStr = "Data Source=" + server + ";port=" + port + ";database=" + database + ";uid=" + uid + ";pwd=" + password + ";"; //mysql
        static string connStr = "Data Source=" + server + ";Initial Catalog = " + database + "; User ID = " + uid + "; Password=" + password + ";";

        public void setConnStr()
        {
            if(connectionType == "mysql")
            {
             sqlconnStr = "Data Source=" + server + ";port=" + port + ";Allow User Variables=True;database=" + database + ";uid=" + uid + ";pwd=" + password + ";"; //mysql server
            }
            else
            {
                connStr = "Data Source=" + server + ";Initial Catalog = " + database + "; User ID = " + uid + "; Password=" + password + ";";//SQL Server
            }
        }
        public Form1()
        {

            InitializeComponent();
            

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            queryBox.Text = "";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // templastQueryText = queryBox.Lines;
            // queryBox.Text = "";
            // for(int i = 0; i < lastQueryText.Length; i++)
            // queryBox.Text+= lastQueryText[i] + "\r\n";
        }
        void printConsole(string str)
        {
            consoleBox.Text += "\r\n" + str;
        }
        private void queryBox_TextChanged(object sender, EventArgs e)
        {
            lastact = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lastact = 1;
        }

        private void clearResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
        }

        void clearQuery() { queryBox.Text = ""; }
        void clearConsole() { consoleBox.Text = ""; }
        void clearResult() { resultBox.Text = ""; }
        void clearAll() { queryBox.Text = ""; resultBox.Text = ""; consoleBox.Text = ""; }
        private void strdec(string str)
        {

            if (connectionType == "mysql")
            {
                sqlconnStr = "Data Source=" + server + ";port=" + port + ";database=" + database + ";uid=" + uid + ";pwd=" + password + ";"; //mysql

            }
            else
            {
                connStr = "Data Source=" + server + ";Initial Catalog = " + database + "; User ID = " + uid + ";Password=" + password + ";";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

      

        private void conButton_Click(object sender, EventArgs e)
        {
            if(ipBox.Text.Length > 4 && portBox.Text.Length > 3 && databaseBox.Text.Length > 0 && uidBox.Text.Length > 0 )
            { 

            
            server = ipBox.Text;
            port = portBox.Text;
            database = databaseBox.Text;
            uid = uidBox.Text;
            password = passwordBox.Text;
        
           
            if (sqlServer.Checked == true) { connectionType = "sql"; } else { connectionType = "mysql"; }//check Server type (SQL/MySQL)
            
            setConnStr();
           // printConsole(server + " " + port + " " + database + " " + uid + " " + password + " " + connectionType); //DEBUG
            if(connectionType == "mysql") { 
                MySqlConnection mcon = new MySqlConnection(sqlconnStr);

                try
                {
                    mcon.Open();
                    statusLabel.Text = "Connected";
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Font = new Font(statusLabel.Font, FontStyle.Bold);
                    usernameLabel.Text = "Connected as: " + uid;
                    databaseLabel.Text = "Database: " + database;
                    mcon.Close();
                    printConsole("Connected successfuly....");
                    
                }
                catch (Exception ex)
                {
                    //printConsole("Error: " + server + " " + port + " " + database + " " + uid + " " + password + " " + connectionType);//DEBUG
                    statusLabel.Text = "FAILED";
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Font = new Font(statusLabel.Font, FontStyle.Bold);
                    printConsole("Error: " + ex.ToString());
                    mcon.Close();
                }//try catch
            }//mysql
            else
            {
                SqlConnection mcon = new SqlConnection(connStr);
                try
                {
                    mcon.Open();
                    statusLabel.Text = "Connected";
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Font = new Font(statusLabel.Font, FontStyle.Bold);
                    usernameLabel.Text = "Connected as: " + uid;
                    databaseLabel.Text = "Database: " + database;
                    consoleBox.Text += "";
                    mcon.Close();
                }
                catch (Exception ex)
                {
                    //printConsole("Error: " + server + " " + port + " " + database + " " + uid + " " + password + " " + connectionType);//DEBUG
                    statusLabel.Text = "FAILED";
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Font = new Font(statusLabel.Font, FontStyle.Bold);
                    printConsole("Error: " + ex.ToString());
                    mcon.Close();
                }//try catch
            }
            }
            else
            {
                printConsole("Error: " + "Credentials cannot be empty!");
            }
        }//conButtonClick

        private void clearQueryButton_Click(object sender, EventArgs e)
        {
            clearQuery();
        }

        private void clearConsoleButton_Click(object sender, EventArgs e)
        {
            clearConsole();
        }

        private void clearResButton_Click(object sender, EventArgs e)
        {
            clearResult();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void selectPreset_Click_1(object sender, EventArgs e)
        {
            queryBox.Clear();
            queryBox.Text = "SELECT * FROM `table`";
        }

        private void updatePreset_Click_1(object sender, EventArgs e)
        {
            queryBox.Clear();
            queryBox.Text = "UPDATE `table`" + "\r\nSET <col> = <value1> ,[col1] = [value2]" + "\r\nWHERE <condition>";
        }

        private void insertPreset_Click_1(object sender, EventArgs e)
        {
            lastQueryText = queryBox.Lines;
            queryBox.Clear();
            queryBox.Text = "INSERT INTO `table` (col1,col2)" + "\r\nVALUES (val1,val2);";
        }

        private void groupbyStat_Click_1(object sender, EventArgs e)
        {
            string ordb = "order by";
            string temp = "";
            if (!queryBox.Text.Contains("ORDER BY"))
            {
                if (!queryBox.Text.Contains("GROUP BY"))
                {
                    queryBox.Text += "\r\nGROUP BY <column>";
                }
            }
            else
            {
                int lncnt = queryBox.Lines.Count();
                //consoleBox.Text += "\r\nCONTAINS"; //DEBUG
                for (int i = 0; i < lncnt; i++)
                {

                    temp = queryBox.Lines[i].ToLower();
                    // consoleBox.Text += "\r\n" + "Lines: " + queryBox.Lines.Count();//DEBUG
                    // consoleBox.Text += "\r\n" + temp + " LINE: " + i;//DEBUG
                    if (temp.Contains(ordb))
                    {
                        int start_ind = queryBox.GetFirstCharIndexFromLine(i);
                        //    consoleBox.Text += "\r\nIn Line " + i;
                        temp = queryBox.Lines[i];
                        queryBox.Text = queryBox.Text.Remove(start_ind, queryBox.Lines[i].Length);

                        queryBox.Text += "GROUP BY <column>";
                        queryBox.Text += "\r\n" + temp;
                    }
                }
            }
        }

        private void orderbyStat_Click(object sender, EventArgs e)
        {
            queryBox.Text += "\r\nORDER BY <col1,col2> ... ASC|DESC;";
        }

        private void deletePreset_Click(object sender, EventArgs e)
        {
            queryBox.Text = "DELETE FROM table_name \r\nWHERE condition;";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            execQuery.Enabled = true;
        }

        private void transactionCB_CheckedChanged(object sender, EventArgs e)
        {

        }
                        //MYSQL
        private void execMysql(bool trans)
        {
            execQuery.Enabled = false;
            if (trans)
            ///////////////////////////////////////////////////////////////
            ///                 IF TRANSACTION IS CHECKED               ///
            ///                THEN THE FOLLOWING LINE RUNS             ///
            ///////////////////////////////////////////////////////////////
            {
                using (MySqlConnection conn = new MySqlConnection(sqlconnStr))
                {
                    conn.Open();
                    consoleBox.Text = "Connection opened! Performing transaction...\r\n";
                    MySqlCommand command = conn.CreateCommand();
                    MySqlTransaction transaction;
                    transaction = conn.BeginTransaction(IsolationLevel.Serializable);   //Serializable isolation level, Μέχρι να ολοκληρωθεί η συναλλαγή ο πίνακας παραμένει δεσμευμένος.
                    command.Connection = conn;
                    command.Transaction = transaction;
                    try
                    {
                        command.CommandText = queryBox.Text;
                      //command.ExecuteNonQuery();
                        MySqlDataReader dataReader = command.ExecuteReader();
                        transaction.Commit();
                        if (dataReader.HasRows)
                        {
                            for (int i = 0; i < dataReader.FieldCount; i++)
                            {
                                resultBox.Text += dataReader.GetName(i);
                                if (dataReader.FieldCount > 1 && i < dataReader.FieldCount - 1) { resultBox.Text += " | "; }
                            }
                            resultBox.Text += "\r\n";
                            while (dataReader.Read())
                            {
                                //  consoleBox.Text += "\r\nFIELD COUNT " + dataReader.FieldCount.ToString(); //DEBUG
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                {
                                    if (dataReader[i] != null && !dataReader.IsDBNull(i))
                                    {
                                        resultBox.Text += (dataReader.GetString(i));
                                    }
                                    else
                                    {
                                        resultBox.Text += "NULL";
                                    }
                                    // if (dataReader.FieldCount > 1 && i < dataReader.FieldCount - 1) { resultBox.Text += " | "; }
                                }
                                resultBox.Text += "\r\n";
                            }
                            dataReader.Close();
                        }
                        else
                        {
                            dataReader.Close();
                            consoleBox.Text += ("\r\nNo rows.");
                        }
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception rb)
                        {
                            if (transaction.Connection != null)
                            {
                                consoleBox.Text += "\r\nCould not rollback transaction: " + rb.ToString();
                            }
                        }
                        consoleBox.Text += "\r\nTransaction Rolled back!";
                        consoleBox.Text += "\r\n" + "Error: " + ex.ToString();
                        execQuery.Enabled = true;
                        return;
                    }//catch
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dt);
                    dataVisual.DataSource = dt;
                    dataAdapter.Dispose();
                    conn.Close();
                }//using sqlconn

                consoleBox.Text += "\r\nDone.";
                execQuery.Enabled = true;

            }
            else
            {
                ///////////////////////////////////////////////////////////////
                ///             IF TRANSACTION IS NOT CHECKED               ///
                ///             THEN THE FOLLOWING LINE RUNS                ///
                ///////////////////////////////////////////////////////////////
                try
                {
                    using (MySqlConnection sqlConn = new MySqlConnection(sqlconnStr))
                    {
                        
                        sqlConn.Open();
                        execQuery.Enabled = false;
                        MySqlCommand command = sqlConn.CreateCommand();

                        command.Connection = sqlConn;
                        try
                        {
                  
                            command.CommandText = queryBox.Text;
                           // command.ExecuteNonQuery(); //Could be Async too !
                            MySqlDataReader dataReader = command.ExecuteReader();//Send the command, and proceeds to read the response
                           
                           
                            if (dataReader.HasRows)
                            {
                               for (int i = 0; i < dataReader.FieldCount; i++)
                               {
                                    //string nt = dataReader.GetName(i);
                                   
                                      //  resultBox.Text += dataReader.GetName(i);
                               //     dt.Columns.Add(new DataColumn(dataReader.GetName(i), typeof(string)));

                                    
                                    
                                   if (dataReader.FieldCount > 1 && i < dataReader.FieldCount - 1) { resultBox.Text += " | "; }
                                }
                                resultBox.Text += "\r\n";
                                while (dataReader.Read())
                                {
                                  // for (int i = 0; i < dataReader.FieldCount; i++)
                                  //  {
                                     //   string nt = dataReader.GetString(i);
                                       // if (dataReader[i] != null && !dataReader.IsDBNull(i) ){ 
                                     //   resultBox.Text += (dataReader.GetString(i));
                                       
                                  //      }
                                      //  else
                                    //    {
                                        //    resultBox.Text += "NULL";
                                        
                                      //  }
                                      //  if (dataReader.FieldCount > 1 && i < dataReader.FieldCount - 1) { resultBox.Text += " | "; }
                                       // printConsole(dataReader.FieldCount.ToString()); //DEBUG
                                //    }
                                 //   resultBox.Text += "\r\n";
                                }
                            //    dataReader.Close();
                            }
                            else
                            {
                               
                               dataReader.Close();
                            //    consoleBox.Text += ("\r\nDone..");
                            }
                        }//try
                        catch (Exception ex)
                        {
                            sqlConn.Close();
                            consoleBox.Text += "\r\nError:" + ex.ToString();
                            
                        }//catch
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        try { 
                        dataAdapter.Fill(dt);
                        dataVisual.DataSource = dt;
                        dataAdapter.Dispose();
                        } catch (Exception ex)
                        {
                            printConsole("Error: " + ex.ToString());
                        }
                        sqlConn.Close();
                        execQuery.Enabled = true;
                    }//using
                }
                catch (Exception ex)
                {
                    consoleBox.Text += "\r\nError: " + ex.ToString();
                    execQuery.Enabled = true;
                }
             
                execQuery.Enabled = true;
            }



        }//execMysql

                        //SQL
        private void execSql(bool trans)
        {

            if(trans)
                ///////////////////////////////////////////////////////////////
                ///                 IF TRANSACTION IS CHECKED               ///
                ///                THEN THE FOLLOWING LINE RUNS             ///
                ///////////////////////////////////////////////////////////////
            {
                execQuery.Enabled = false;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    consoleBox.Text = "Connection opened! Performing transaction...\r\n";
                    SqlCommand command = conn.CreateCommand();
                    SqlTransaction transaction;
                    transaction = conn.BeginTransaction(IsolationLevel.Serializable);   //Serializable isolation level, Μέχρι να ολοκληρωθεί η συναλλαγή ο πίνακας παραμένει δεσμευμένος.
                    command.Connection = conn;
                    command.Transaction = transaction;
                    try
                    {

                        command.CommandText = queryBox.Text;
                        //command.ExecuteNonQuery();
                        SqlDataReader dataReader = command.ExecuteReader();
                        transaction.Commit();
                        if (dataReader.HasRows)
                        {
                            for (int i = 0; i < dataReader.FieldCount; i++)
                            {
                                resultBox.Text += dataReader.GetName(i);
                                if (dataReader.FieldCount > 1 && i < dataReader.FieldCount - 1) { resultBox.Text += " | "; }
                            }
                            resultBox.Text += "\r\n";
                            while (dataReader.Read())
                            {
                              
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                {
                                    if (dataReader[i] != null && !dataReader.IsDBNull(i))
                                    {
                                        resultBox.Text += (dataReader.GetString(i));
                                    }
                                    else
                                    {
                                        resultBox.Text += "NULL";
                                    }
                                    if (dataReader.FieldCount > 1 && i < dataReader.FieldCount - 1) { resultBox.Text += " | "; }
                                }
                                resultBox.Text += "\r\n";
                            }
                            dataReader.Close();
                        }
                        else
                        {
                            consoleBox.Text += ("\r\nNo rows.");
                        }
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception rb)
                        {
                            if (transaction.Connection != null)
                            {
                                consoleBox.Text += "\r\nCould not rollback transaction: " + rb.ToString();
                            }
                        }
                        consoleBox.Text += "\r\nTransaction Rolled back!";
                        consoleBox.Text += "\r\n" + "Error: " + ex.ToString();
                        return;
                    }//catch
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dt);
                    dataVisual.DataSource = dt;
                    dataAdapter.Dispose();
                    conn.Close();
                }//using sqlconn
                consoleBox.Text += "\r\nDone.";
                execQuery.Enabled = true;
            }
            else
            {
                ///////////////////////////////////////////////////////////////
                ///             IF TRANSACTION IS NOT CHECKED               ///
                ///             THEN THE FOLLOWING LINE RUNS                ///
                ///////////////////////////////////////////////////////////////
                try
                {
                    using (SqlConnection sqlConn = new SqlConnection(connStr))
                    {

                        sqlConn.Open();
                        execQuery.Enabled = false;
                        SqlCommand command = sqlConn.CreateCommand();
                        command.Connection = sqlConn;
                        try
                        {
                            command.CommandText = queryBox.Text;
                            //command.ExecuteNonQuery();
                            SqlDataReader dataReader = command.ExecuteReader();
                            if (dataReader.HasRows)
                            {
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                {
                                    resultBox.Text += dataReader.GetName(i);
                                    if (dataReader.FieldCount > 1 && i < dataReader.FieldCount - 1) { resultBox.Text += " | "; }
                                }
                                resultBox.Text += "\r\n";
                                while (dataReader.Read())
                                {
                               
                                    for (int i = 0; i < dataReader.FieldCount; i++)
                                    {
                                        if (dataReader[i] != null && !dataReader.IsDBNull(i))
                                        {
                                            resultBox.Text += (dataReader.GetString(i));
                                        }
                                        else
                                        {
                                            resultBox.Text += "NULL";
                                        }
                                        if (dataReader.FieldCount > 1 && i < dataReader.FieldCount - 1) { resultBox.Text += " | "; }
                                    }
                                    resultBox.Text += "\r\n";
                                }
                                dataReader.Close();
                            }
                            else
                            {
                                consoleBox.Text += ("\r\nNo rows.");
                            }

                        }
                        catch (Exception ex)
                        {
                            consoleBox.Text += "\r\nError:" + ex.ToString();
                        }
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dt);
                        dataVisual.DataSource = dt;
                        dataAdapter.Dispose();
                        sqlConn.Close();
                        execQuery.Enabled = true;
                    }//using
                }
                catch (Exception ex)
                {
                    consoleBox.Text += "\r\nError: " + ex.ToString();
                    execQuery.Enabled = true;
                }

                execQuery.Enabled = true;
            }
        }//execSql




        private void execQuery_Click_1(object sender, EventArgs e)
        {
            resultBox.Text = "";
            dt.Dispose();
            dt.Rows.Clear();
            dt.Columns.Clear();
            while (dataVisual.Rows.Count > 0)
                dataVisual.Rows.RemoveAt(0);
            dataVisual.Columns.Clear();
            dataVisual.DataBindings.Clear();
            dataVisual.Refresh();
       
            

            if (queryBox.TextLength > 0)
            {
                if (connectionType == "mysql")
                {
                    if (transactionCB.Checked)
                    {
                        execMysql(true);
                    }//if checked
                    else
                    {
                        execMysql(false);
                    }//if not checked

                }//if MySQL SERVER
                else
                {
                    if (transactionCB.Checked)
                    {
                        execSql(true);
                    }//if checked
                    else
                    {
                        execSql(false);
                    }//if not checked

                }//if SQL Server
            }//if 
            else
            {
                printConsole("Error: can't execute empty queries!");
            }//else
        }//execQueryClick
        private void createtableButton_Click_1(object sender, EventArgs e)
        {
            queryBox.Text = "CREATE TABLE table_name (\r\ncolumn1 datatype,\r\ncolumn2 datatype,\r\ncolumn3 datatype,\r\n...\r\n); ";
        }

        private void alterTableButton_Click_1(object sender, EventArgs e)
        {
            queryBox.Text = "ALTER TABLE table_name\r\nADD column_name datatype;";
        }

        private void dropTable_Click_1(object sender, EventArgs e)
        {
            queryBox.Text = "DROP TABLE table_name;";
        }
    }

}
