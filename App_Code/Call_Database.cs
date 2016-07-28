﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Call_Database
/// </summary>
public class Call_Database
{
    private const string conn = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DonorsRec.mdf;Integrated Security = True";
    public DataTable Advdt;
    private DataTable _Advdt;
    public DataTable Elecdt;
    private DataTable _Elecdt;
    public DataTable dtDonors;
    private DataTable _dtDonors;
    public DataTable dtFounders;
    private DataTable _dtFounders;
    public DataTable dtScholarships;
    private DataTable _dtScholarships;
    public DataTable dtCornerstone;
    private DataTable _dtCornerstone;
    public DataTable dtRoundtable;
    private DataTable _dtRoundtable;
    public DataTable dtPresidentsTab;
    private DataTable _dtPresidentsTab;
    public DataTable dtQuadrangleTab;
    private DataTable _dtQuadrangleTab;
    public DataTable dtBlueGoldTab;
    private DataTable _dtBlueGoldTab;
    public DataTable dtCenturyTab;
    private DataTable _dtCenturyTab;
    public DataTable dtOtherDonorsTab;
    private DataTable _dtOtherDonorsTab;

    /// <summary>
    /// Donors Map Datatables are as follows
    /// </summary>
    /// Fisher Hall
    /// public DataTable Test;
    /// private DataTable _Test;
    public DataTable dtFisherHall;
    private DataTable _dtFisherHall;
    public DataTable dtCommons;
    private DataTable _dtCommons;
    public DataTable dtLibrary;
    private DataTable _dtLibrary;
    public DataTable dtSwartsHall;
    private DataTable _dtSwartsHall;
    public DataTable dtBlaisdellHall;
    private DataTable _dtBlaisdellHall;
    public DataTable dtFitnessCenter;
    private DataTable _dtFitnessCenter;
    public DataTable dtResidence;
    private DataTable _dtResidence;

    public Call_Database()
    {
        DataTable Advdt = new DataTable();
        DataTable Elecdt = new DataTable();
        DataTable dtDonors = new DataTable();
        DataTable dtFounders = new DataTable();
        DataTable dtScholarships = new DataTable();
        DataTable dtCornerstone = new DataTable();
        DataTable dtRoundtable = new DataTable();
        DataTable dtPresidentsTab = new DataTable();
        DataTable dtQuadrangleTab = new DataTable();
        DataTable dtBlueGoldTab = new DataTable();
        DataTable dtCenturyTab = new DataTable();
        DataTable dtOtherDonorsTab = new DataTable();
        LoadAdv(Advdt);
        _Advdt = Advdt;
        LoadElec(Elecdt);
        _Elecdt = Elecdt;
        LoadDonors(dtDonors);
        _dtDonors = dtDonors;
        LoadFounders(dtFounders);
        _dtFounders = dtFounders;
        LoadScholarships(dtScholarships);
        _dtScholarships = dtScholarships;
        LoadRoundtable(dtRoundtable);
        _dtRoundtable = dtRoundtable;
        LoadCornerstone(dtCornerstone);
        _dtCornerstone = dtCornerstone;
        LoadPresidentsTab(dtPresidentsTab);
        _dtPresidentsTab = dtPresidentsTab;
        LoadQuadrangleTab(dtQuadrangleTab);
        _dtQuadrangleTab = dtQuadrangleTab;
        LoadBlueGoldTab(dtBlueGoldTab);
        _dtBlueGoldTab = dtBlueGoldTab;
        LoadCenturyTab(dtCenturyTab);
        _dtCenturyTab = dtCenturyTab;
        LoadOtherDonorsTab(dtOtherDonorsTab);
        _dtOtherDonorsTab = dtOtherDonorsTab;

        ///Following is new Definitions for Donors_Map
        DataTable dtFisherHall = new DataTable();
        LoadFisherHall(dtFisherHall);
        _dtFisherHall = dtFisherHall;
        DataTable dtCommons = new DataTable();
        LoadCommons(dtCommons);
        _dtCommons = dtCommons;
        DataTable dtLibrary = new DataTable();
        LoadLibrary(dtLibrary);
        _dtLibrary = dtLibrary;
        DataTable dtSwartsHall = new DataTable();
        LoadSwartsHall(dtSwartsHall);
        _dtSwartsHall = dtSwartsHall;
        DataTable dtBlaisdellHall = new DataTable();
        LoadBlaisdellHall(dtBlaisdellHall);
        _dtBlaisdellHall = dtBlaisdellHall;
        DataTable dtFitnessCenter = new DataTable();
        LoadFitnessCenter(dtFitnessCenter);
        _dtFitnessCenter = dtFitnessCenter;
        DataTable dtResidence = new DataTable();
        LoadResidence(dtResidence);
        _dtResidence = dtResidence;
    }

    public DataTable AdvBoard
        {
        get{ return _Advdt; }
        set{ _Advdt = value; }
         }
    public DataTable ElecBoard
    {
        get { return _Elecdt; }
        set { _Elecdt = value; }
    }

    public DataTable dbDonors
    {
        get { return _dtDonors; }
        set { _dtDonors = value;}
    }

    public DataTable dbFounders
    {
        get { return _dtFounders; }
        set { _dtFounders = value; }
    }
    public DataTable dbScholarships
    {
        get { return _dtScholarships; }
        set { _dtScholarships = value; }
    }
    public DataTable dbRoundtable
    {
        get { return _dtRoundtable; }
        set { _dtRoundtable = value; }
    }
    public DataTable dbCornerstone
    {
        get { return _dtCornerstone; }
        set { _dtCornerstone = value; }
    }
    public DataTable dbPresidentsTab
    {
        get { return _dtPresidentsTab; }
        set { _dtPresidentsTab = value; }
    }
    public DataTable dbQuadrangleTab
    {
        get { return _dtQuadrangleTab; }
        set { _dtQuadrangleTab = value; }
    }
    public DataTable dbBlueGoldTab
    {
        get { return _dtBlueGoldTab; }
        set { _dtBlueGoldTab = value; }
    }
    public DataTable dbCenturyTab
    {
        get { return _dtCenturyTab; }
        set { _dtCenturyTab = value; }
    }
    public DataTable dbOtherDonorsTab
    {
        get { return _dtOtherDonorsTab; }
        set { _dtOtherDonorsTab = value; }
    }

    /// <summary>
    /// Donors Map Datatable Get:Set
    /// </summary>

    public DataTable dbFisherHall
    {
        get { return _dtFisherHall; }
        set { _dtFisherHall = value; }
    }

    public DataTable dbCommons
    {
        get { return _dtCommons; }
        set { _dtCommons = value; }
    }

    public DataTable dbLibrary
    {
        get { return _dtLibrary; }
        set { _dtLibrary = value; }
    }

    public DataTable dbSwartsHall
    {
        get { return _dtSwartsHall; }
        set { _dtSwartsHall = value; }
    }

    public DataTable dbBlaisdellHall
    {
        get { return _dtBlaisdellHall; }
        set { _dtBlaisdellHall = value; }
    }

    public DataTable dbFitnessCenter
    {
        get { return _dtFitnessCenter; }
        set { _dtFitnessCenter = value; }
    }

    public DataTable dbResidence
    {
        get { return _dtResidence; }
        set { _dtResidence = value; }
    }
    /// <summary>
    /// Basic Commands for Database
    /// </summary>

    public void Add(string Namebox, string Imagename, string Profiletxt)
    {
        using (SqlConnection conn = new SqlConnection(Call_Database.conn))
        {
            SqlCommand CmdSql = new SqlCommand("INSERT INTO [donors] (name, photo, profile) VALUES (@name, @photo, @profile)", conn);
            conn.Open();
            CmdSql.Parameters.AddWithValue("@Name", Namebox);
            CmdSql.Parameters.AddWithValue("@photo", "Images/dbImages/" + Imagename);
            CmdSql.Parameters.AddWithValue("@profile", Profiletxt);
            CmdSql.ExecuteNonQuery();
            conn.Close();
        }
    }

    public void Focus(int Id)
    {
        using (SqlConnection conn = new SqlConnection(Call_Database.conn))
        {
            SqlCommand CmdSql = new SqlCommand("SELECT (name, photo, profile) FROM [donors] WHERE (Id) VALUES (@Id)", conn);
            conn.Open();
            CmdSql.ExecuteNonQuery();
            conn.Close();
        }
    }

    public void Delete(int deleteId)
    {
        using (SqlConnection conn = new SqlConnection(Call_Database.conn))
        {
            SqlCommand CmdSql = new SqlCommand("DELETE FROM [donors] WHERE[Id] = @deleteId",conn);
            conn.Open();
            CmdSql.Parameters.AddWithValue("@deleteId", deleteId);
            CmdSql.ExecuteNonQuery();
            conn.Close();
        }
    }

    /// <summary>
    /// Database Load Connections
    /// </summary>

public void LoadAdv(DataTable Advdt)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM AdvBoard";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drAdvBoard;
        conn.Open();
        drAdvBoard = cmd.ExecuteReader();
        Advdt.Load(drAdvBoard);
        conn.Close();
    }

    public void LoadElec(DataTable Elecdt)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ElecBoard";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drElecBoard;
        conn.Open();
        drElecBoard = cmd.ExecuteReader();
        Elecdt.Load(drElecBoard);
        conn.Close();
    }

    public void LoadDonors(DataTable dtDonors)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM donors";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drDonors;
        conn.Open();
        drDonors = cmd.ExecuteReader();
        dtDonors.Load(drDonors);
        conn.Close();
    }

    public void LoadFounders(DataTable dtFounders)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM Founders";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drFounders;
        conn.Open();
        drFounders = cmd.ExecuteReader();
        dtFounders.Load(drFounders);
        conn.Close();
    }

    public void LoadScholarships(DataTable dtScholarships)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM Scholarships";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drScholarships;
        conn.Open();
        drScholarships = cmd.ExecuteReader();
        dtScholarships.Load(drScholarships);
        conn.Close();
    }

    public void LoadCornerstone(DataTable dtCornerstone)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM CornerstoneTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drCornerstone;
        conn.Open();
        drCornerstone = cmd.ExecuteReader();
        dtCornerstone.Load(drCornerstone);
        conn.Close();
    }

    public void LoadRoundtable(DataTable dtRoundtable)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM RoundtableTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drRoundtable;
        conn.Open();
        drRoundtable = cmd.ExecuteReader();
        dtRoundtable.Load(drRoundtable);
        conn.Close();
    }

    public void LoadPresidentsTab(DataTable dtPresidentsTab)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM PresidentsTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drPresidentsTab;
        conn.Open();
        drPresidentsTab = cmd.ExecuteReader();
        dtPresidentsTab.Load(drPresidentsTab);
        conn.Close();
    }

    public void LoadQuadrangleTab(DataTable dtQuadrangleTab)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM QuadrangleTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drQuadrangleTab;
        conn.Open();
        drQuadrangleTab = cmd.ExecuteReader();
        dtQuadrangleTab.Load(drQuadrangleTab);
        conn.Close();
    }

    public void LoadBlueGoldTab(DataTable dtBlueGoldTab)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM BlueGoldTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drBlueGoldTab;
        conn.Open();
        drBlueGoldTab = cmd.ExecuteReader();
        dtBlueGoldTab.Load(drBlueGoldTab);
        conn.Close();
    }

    public void LoadCenturyTab(DataTable dtCenturyTab)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM CenturyTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drCenturyTab;
        conn.Open();
        drCenturyTab = cmd.ExecuteReader();
        dtCenturyTab.Load(drCenturyTab);
        conn.Close();
    }

    public void LoadOtherDonorsTab(DataTable dtOtherDonorsTab)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM OtherDonorsTab";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drOtherDonorsTab;
        conn.Open();
        drOtherDonorsTab = cmd.ExecuteReader();
        dtOtherDonorsTab.Load(drOtherDonorsTab);
        conn.Close();
    }

    ///Donors_Map Load Connections
    public void LoadFisherHall(DataTable dtFisherHall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM FisherHallInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drFisherHall;
        conn.Open();
        drFisherHall = cmd.ExecuteReader();
        dtFisherHall.Load(drFisherHall);
        conn.Close();
    }

    public void LoadCommons(DataTable dtCommons)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM CommonsInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drCommons;
        conn.Open();
        drCommons = cmd.ExecuteReader();
        dtCommons.Load(drCommons);
        conn.Close();
    }

    public void LoadLibrary(DataTable dtLibrary)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM LibraryInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drLibrary;
        conn.Open();
        drLibrary = cmd.ExecuteReader();
        dtLibrary.Load(drLibrary);
        conn.Close();
    }

    public void LoadSwartsHall(DataTable dtSwartsHall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM SwartsHallInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drSwartsHall;
        conn.Open();
        drSwartsHall = cmd.ExecuteReader();
        dtSwartsHall.Load(drSwartsHall);
        conn.Close();
    }

    public void LoadBlaisdellHall(DataTable dtBlaisdellHall)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM BlaisdellHallInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drBlaisdellHall;
        conn.Open();
        drBlaisdellHall = cmd.ExecuteReader();
        dtBlaisdellHall.Load(drBlaisdellHall);
        conn.Close();
    }

    public void LoadFitnessCenter(DataTable dtFitnessCenter)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM FitnessCenterInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drFitnessCenter;
        conn.Open();
        drFitnessCenter = cmd.ExecuteReader();
        dtFitnessCenter.Load(drFitnessCenter);
        conn.Close();
    }

    public void LoadResidence(DataTable dtResidence)
    {
        SqlConnection conn = new SqlConnection(Call_Database.conn);
        string command = "SELECT * FROM ResHallInfo";
        SqlCommand cmd = new SqlCommand(command, conn);
        SqlDataReader drResidence;
        conn.Open();
        drResidence = cmd.ExecuteReader();
        dtResidence.Load(drResidence);
        conn.Close();
    }
}