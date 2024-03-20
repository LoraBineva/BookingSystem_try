namespace Flights_Agency_App;

using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using static Flights_Agency_App.Authenticate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    SqlConnection sql;

    private void Form1_Load(object sender, EventArgs e)
    {

        try
        {
            sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=Flight_Agency; Integrated Security=True;");
            sql.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        string fetchDeperture = "SELECT DISTINCT Departure From Flights WHERE 1=1";
        SqlCommand cmd = new SqlCommand(fetchDeperture, sql);
        cmd.CommandType = CommandType.Text;

        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
        {
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Departure.DataSource = ds.Tables[0];
            Departure.DisplayMember = "Departure";
        }
        Departure.SelectedIndex = -1;

    }

    private void Departure_SelectedIndexChanged(object sender, EventArgs e)
    {
        string fetchDestination = "SELECT DISTINCT Destination From Flights WHERE Departure=@Departure";
        SqlCommand cmd2 = new SqlCommand(fetchDestination, sql);
        cmd2.CommandType = CommandType.Text;
        cmd2.Parameters.AddWithValue("@Departure", Departure.Text);
        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd2))
        {
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Destination.DataSource = ds.Tables[0];
            Destination.DisplayMember = "Destination";
        }
        Destination.SelectedIndex = -1;
    }

    private void Destination_SelectedIndexChanged(object sender, EventArgs e)
    {
        string fetchFromDate = "SELECT DISTINCT From_Date From Flights WHERE Departure=@Departure AND Destination=@Destination";
        SqlCommand cmd3 = new SqlCommand(fetchFromDate, sql);
        cmd3.CommandType = CommandType.Text;
        cmd3.Parameters.AddWithValue("@Departure", Departure.Text);
        cmd3.Parameters.AddWithValue("@Destination", Destination.Text);
        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd3))
        {
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            From_Date.DataSource = ds.Tables[0];
            From_Date.DisplayMember = "From_Date";
        }
        string fetchToDate = "SELECT DISTINCT To_Date From Flights WHERE Departure=@Departure AND Destination=@Destination";
        SqlCommand cmd4 = new SqlCommand(fetchToDate, sql);
        cmd4.CommandType = CommandType.Text;
        cmd4.Parameters.AddWithValue("@Departure", Departure.Text);
        cmd4.Parameters.AddWithValue("@Destination", Destination.Text);
        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd4))
        {
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            To_Date.DataSource = ds.Tables[0];
            To_Date.DisplayMember = "To_Date";
        }
        From_Date.SelectedIndex = -1;
        To_Date.SelectedIndex = -1;

    }

    private void button1_Click(object sender, EventArgs e)
    {
        string query = "SELECT flightID, Departure, Destination, From_Date, To_Date, Airline, Price FROM Flights WHERE 1=1\r\n";
        if (Departure.SelectedIndex != -1 && Destination.SelectedIndex != -1)
        {
            query += "AND Departure=@Departure AND Destination=@Destination";
            if (From_Date.SelectedIndex != -1)
            {
                query += " AND From_Date=@From_Date";
            }
            if (From_Date.SelectedIndex != -1)
            {
                query += " AND To_Date=@To_Date";
            }
            SqlCommand cmd5 = new SqlCommand(query, sql);
            cmd5.CommandType = CommandType.Text;
            cmd5.Parameters.AddWithValue("@Departure", Departure.Text);
            cmd5.Parameters.AddWithValue("@Destination", Destination.Text);
            cmd5.Parameters.AddWithValue("@From_Date", From_Date.Text);
            cmd5.Parameters.AddWithValue("@To_Date", To_Date.Text);
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd5))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Flight_Data.DataSource = ds.Tables[0];
            }
        }
        else
        {
            MessageBox.Show("Please select a starting point and a destination from the list", "Error", MessageBoxButtons.OK);
        }
    }

    private void Flight_Data_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (Flight_Data.SelectedRows.Count == 1)
        {
            DataGridViewRow selectedRow = Flight_Data.SelectedRows[0];
            string flightNumber = selectedRow.Cells["flightID"].Value.ToString();
            Authenticate.User authenticatedUser = DatabaseManager.;
            Log_In log_In = new Log_In();
            log_In.Show();
        }
        else
        {
            MessageBox.Show("Please select only one flight to book", "Error", MessageBoxButtons.OK);
        }
    }
}
