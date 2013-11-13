using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web;
using System.Net.Mail;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Net;
using System.Linq;
using System.Globalization;

public class csFunctions
{

    public String csCountry(string country)
    {

        if (country.ToUpper() == "GR".ToUpper())
        {
            return "gr";
        }
        else if (country.ToUpper() == "AD".ToUpper() || country.ToUpper() == "AT".ToUpper() || country.ToUpper() == "BE".ToUpper() || country.ToUpper() == "CY".ToUpper()
            || country.ToUpper() == "EE".ToUpper() || country.ToUpper() == "FI".ToUpper() || country.ToUpper() == "FR".ToUpper() || country.ToUpper() == "DE".ToUpper()
            || country.ToUpper() == "IE".ToUpper() || country.ToUpper() == "IT".ToUpper() || country.ToUpper() == "KR".ToUpper() || country.ToUpper() == "LU".ToUpper()
            || country.ToUpper() == "MT".ToUpper() || country.ToUpper() == "MC".ToUpper() || country.ToUpper() == "Montenegro".ToUpper() || country.ToUpper() == "NL".ToUpper()
            || country.ToUpper() == "PT".ToUpper() || country.ToUpper() == "SM".ToUpper() || country.ToUpper() == "SK".ToUpper() || country.ToUpper() == "SI".ToUpper()
            || country.ToUpper() == "ES".ToUpper() || country.ToUpper() == "Vatican City".ToUpper())
        {
            return "eu";
        }
        else
        {
            return "rest";
        }
    }

    public String csAvailability(String ssAvail, int siAvail1, int siAvail2, Double sbStock)
    {
        String psAvail;
        String psColor;
        String psReturn;

        psAvail = "";
        psColor = "White";

        if (ssAvail.Length > 0)
        {
            psAvail = ssAvail;
        }
        else if (sbStock <= 0 && siAvail1 > 0)
        {
            psAvail = "&nbsp;Μη Διαθέσιμο&nbsp;";
            psColor = "Red";
        }
        else if (sbStock > 0 && sbStock <= siAvail1 && siAvail1 > 0)
        {
            psAvail = "&nbsp;Χαμηλή&nbsp;";
            psColor = "Orange";
        }
        else if (sbStock > siAvail1 && sbStock <= siAvail2 && siAvail1 > 0)
        {
            psAvail = "&nbsp;Περιορισμένη&nbsp;";
            psColor = "DodgerBlue";
        }
        else if (sbStock > siAvail2 && siAvail2 > 0)
        {
            psAvail = "&nbsp;Πλήρης&nbsp;";
            psColor = "Green";
        }

        psReturn = "<span style='font-weight:bold;background-color:" + psColor + ";'>" + psAvail + "</span>";
        return psReturn;
    }

    public String csQuote(Object ssInput)
    {
        String psEx;
        String sValue = "";

        try
        {
            if (ssInput == System.DBNull.Value)
            {
                sValue = "''";
            }
            else
            {
                sValue = Convert.ToString(ssInput) + "";
                sValue = sValue.Replace("'", "''");
                sValue = "'" + sValue + "" + "'";
            }
        }
        catch (Exception ex)
        {
            psEx = ex.Message;
            sValue = "''";
        }
        return sValue;
    }

    public Boolean csIsNumeric(String ssVal, System.Globalization.NumberStyles snNumberStyle)
    {
        
        Double result;
        return Double.TryParse(ssVal, snNumberStyle,
            System.Globalization.CultureInfo.CurrentCulture, out result);
    }

    public Boolean csIsDate(String ssVal)
    {

        DateTime result;
        return DateTime.TryParse(ssVal, out result);
    }

    public int csSqlBool(Object ssInput)
    {
        String psEx;
        int sValue = 0;

        try
        {
            if (ssInput == System.DBNull.Value)
            {
                sValue = 0;
            }
            else
            {
                sValue = Convert.ToInt16(ssInput);
            }
        }
        catch (Exception ex)
        {
            psEx = ex.Message;
            sValue = 0;
        }

        return sValue;
    }

    public String csSqlDate(Object ssInput)
    {
        String psEx;
        String sValue = "";
        String psInput;

        try
        {
            if (ssInput == System.DBNull.Value)
            { return "Null"; }

            psInput = Convert.ToString(ssInput) + "";

            if (psInput.Length == 0)
            { return "Null"; }

            if (psInput == "00/00/00")
            { return "Null"; }

            DateTime sdDate = Convert.ToDateTime(psInput);
            sValue = "'" + sdDate.ToString("yyyy/MM/dd") + "'";
        }
        catch (Exception ex)
        {
            psEx = ex.Message;
            sValue = "Null";
        }

        return sValue;
    }

    public String csSqlVal(Object ssInput)
    {
        String psEx;
        String sValue = "";
        String psInput;

        try
        {
            if (ssInput == System.DBNull.Value)
            { return "0"; }

            psInput = Convert.ToString(ssInput) + "";

            if (psInput.Length == 0)
            { return "0"; }

            psInput = psInput.Replace(".", "");
            sValue = psInput.Replace(",", ".");
        }
        catch (Exception ex)
        {
            psEx = ex.Message;
            sValue = "0";
        }
        return sValue;
    }


    public String csMid(String param, int startIndex, int length)
    {
        string result = param.Substring(startIndex-1, length);
        return result;
    }

    public String csLeft(String param, int siLength)
    {
        String result = param;
        if (param.Length > siLength)
        {
            result = param.Substring(0, siLength);
        }
        return result;
    }

    public String csRight(String param, int siLength)
    {
        String result = param;
        int piStart;

        if (param.Length > siLength)
        {
            piStart = param.Length - siLength;
            result = param.Substring(piStart, siLength);
        }
        return result;
    }

    //        string result = sdDate.ToString("d");
    public String csDateDisp(String ssDate, String ssFormat)
    {
        string result = "";
        if (ssDate == null)
        {
            result = "";
        }
        else if (ssDate.Length == 0)
        {
            result = "";
        }
        else
        {
            DateTime sdDate = Convert.ToDateTime(ssDate);
            result = sdDate.ToString(ssFormat);
        }

        return result;
    }

    public String csZz(Double sdNum, String ssFormat)
    {
        String result = "";
        if (ssFormat == "#.00")
        {
            ssFormat = "####,###.00";
        }

        result = sdNum.ToString(ssFormat);
        return result;
    }


    public Boolean csValidInput(String ssInput, int siLength)
    {
        Boolean pbRet;
        String psInput;

        psInput = ssInput.ToUpper();
        pbRet = true;

        if (siLength > 0 && psInput.Length > siLength)
        {
            pbRet = false;
        }

        if (psInput.Contains("SELECT"))
        {
            pbRet = false;
        }

        if (psInput.Contains("CREATE"))
        {
            pbRet = false;
        }

        if (psInput.Contains("DELETE"))
        {
            pbRet = false;
        }

        if (psInput.Contains("UPDATE"))
        {
            pbRet = false;
        }

        if (psInput.Contains("INSERT"))
        {
            pbRet = false;
        }

        if (psInput.Contains("DROP"))
        {
            pbRet = false;
        }

        return pbRet;
    }


    public Boolean csIsNull(String ssInput)
    {
        Boolean bOk = false;
        String psInput;
        String psEx;

        try
        {
            if (ssInput == null)
            {
                bOk = true;
                return bOk;
            }
            psInput = Convert.ToString(ssInput).Trim();

            if (psInput.Length == 0)
            {
                bOk = true;
            }
        }
        catch (Exception ex)
        {
            psEx = ex.Message;
            bOk = false;
        }

        return bOk;
    }


    public String csFillNbsp(String param, int siLength)
    {
        String result;
        String psKena;
        int i;
        int piFill;

        psKena = "";
        if (param.Length < siLength && siLength > 0)
        {
            piFill = siLength - param.Length;
            for (i = 0; i < piFill; i++)
            {
                psKena += "&nbsp;";
            }
        }

        result = param + psKena;
        return result;
    }


    public String csSplit(String ssInput, int siIndex, String sDelimit)
    {
        String sValue = "";
        try
        {
            String wString = ssInput;
            int wC = 0;
            int intStartPos = 0;
            int intCounter = 0;
            int i=0;
            int intEndPos=0;

            if (wString.Length > 0)
            {
                wString = wString + sDelimit;
                intCounter = 0;
                intStartPos = 0;

                wC = 0;
                for (i = 0; i < wString.Length; i++)
                {
                    if (wString.Substring(i, 1) == sDelimit) 
                    {
                        wC = wC + 1;
                    }
                }
                if (wC >= siIndex)
                {
                    for (intCounter = 1; intCounter < siIndex; intCounter++)
                    {
                        intStartPos = wString.IndexOf(sDelimit, intStartPos) + 1;
                    }
                    intEndPos = wString.IndexOf(sDelimit, intStartPos) - 1;
                    if (intEndPos <= 0)
                    {
                        sValue = "";
                    }
                    else
                    {
                        sValue = wString.Substring(intStartPos, intEndPos - intStartPos + 1);
                    }
                }
            }
        }
        catch {}
        return sValue;
    }

    

    public Boolean csValidEmail(String ssInput)
    {
        String psInput;
        Boolean pbValue = true;
        int iFiA;
        int iLaA;
        int bE;

        psInput = ssInput.Trim();
        bE = 0;

        // Check min length
        if (psInput.Length < 5)
        {
            bE = 1;
        }

        // Check for @
        iFiA = psInput.IndexOf("@");
        if (iFiA <= 0)
        {
            bE = 1;
        }
        iLaA = psInput.LastIndexOf("@");

        if (iFiA != iLaA)
        {
            bE = 1;
        }

        //
        if (bE == 1)
        {
            pbValue = false;
        }
        return pbValue;
    }

    public Boolean csCheckAfm(Object ssInput)
    {
        Boolean bOk = true;
        String psAfm;
        String psAfm1;
        int piDig;
        int Syn_dig1;
        int Syn_dig2;
        int Syn_dig3;
        int x;


        if (ssInput == null)
        {
            return true;
        }

        psAfm = Convert.ToString(ssInput) + "";
        psAfm = psAfm.Trim();
        if (psAfm.Length == 0)
        {
            return true;
        }
        if (psAfm.Length != 9)
        {
            return true;
        }

        piDig = 0;
        for (x = 1; x < 9; x++)
        {
            psAfm1 = csMid(psAfm, x, 1);
            piDig = piDig + Convert.ToInt32(psAfm1) * Convert.ToInt32(Math.Pow(2, (9 - x)));
        }

        Syn_dig1 = piDig / 11;
        Syn_dig2 = Syn_dig1 * 11;
        Syn_dig3 = piDig - Syn_dig2;
        if (Syn_dig3 > 9)
        {
            Syn_dig3 = 0;
        }

        psAfm1 = csMid(psAfm, 9, 1);
        piDig = Convert.ToInt32(psAfm1);
        if (Syn_dig3 != piDig)
        {
            bOk = false;
        }
        return bOk;
    }


    

    public Double cdPriceBase(Byte sbXond, Byte sbArxTel, Object poPrice, Object poPricV, Object poEkpp)
    {
        Double pdPrice;
        Double pdPricV;
        Double pdEkpP;
        Double pdTmonArx;
        Double pdTmonTel;

        if (poPrice == System.DBNull.Value)
        {
            pdPrice = 0;
        }
        else
        {
            pdPrice = Convert.ToDouble(poPrice);
        }

        if (poPricV == System.DBNull.Value)
        {
            pdPricV = 0;
        }
        else
        {
            pdPricV = Convert.ToDouble(poPricV);
        }

        if (poEkpp == System.DBNull.Value)
        {
            pdEkpP = 0;
        }
        else
        {
            pdEkpP = Convert.ToDouble(poEkpp);
        }

        //Υπολογισμός τιμής χωρίς έκπτωση
        pdTmonArx = 0;
        if (sbXond == 1)
        {
            pdTmonArx = pdPrice;
        }
        else
        {
            pdTmonArx = pdPricV;
        }

        //Υπολογισμός τιμής μετά έκπτωση
        pdTmonTel = pdTmonArx;
        if (pdEkpP != 0)
        {
            pdTmonTel = Math.Round(pdTmonArx - pdTmonArx * pdEkpP / 100, 2);
        }

        if (sbArxTel == 1)
        {
            return pdTmonArx;
        }
        else
        {
            return pdTmonTel;
        }
    }


    //public Double csCompanyDisc(String ssComAn, String ssProID, ref String ssRc, SqlConnection sqlCnn)
    //{
    //    csSqlHandle hsSqlHandle = new csSqlHandle();
    //    SqlDataReader sqlRs;
    //    String sSql;
    //    Double pdDisc;
    //    String psRc;
    //    Double pdEkp1;
    //    Byte pbIsxi;
    //    String pdDate;
    //    String pdNow;
    //    String psPrgAn;
    //    String psPrcAn;

    //    ssRc = "";
    //    psRc = "";
    //    pdDisc = 0;

    //    //Find PrgAn + PrcAn
    //    psPrgAn = "";
    //    psPrcAn = "";
    //    sSql = "SELECT Product.PrgAn, Product.PrcAn";
    //    sSql += " FROM Product";
    //    sSql += " WHERE Product.ProID = " + csQuote(ssProID);
    //    sqlRs = hsSqlHandle.sqlFileOpen(sSql, sqlCnn, ref psRc);
    //    if (psRc.Length > 0)
    //    {
    //        psRc = ssRc;
    //        return 0;
    //    }
    //    while (sqlRs.Read())
    //    {
    //        psPrgAn = sqlRs["PrgAn"].ToString();
    //        psPrcAn = sqlRs["PrcAn"].ToString();
    //    }
    //    hsSqlHandle.sqlFileClose(sqlRs);


    //    //Find Company discount
    //    pdEkp1 = 0;
    //    sSql = "SELECT Company.ComEkp1";
    //    sSql += " FROM Company";
    //    sSql += " WHERE Company.ComAn = " + csQuote(ssComAn);
    //    sqlRs = hsSqlHandle.sqlFileOpen(sSql, sqlCnn, ref psRc);
    //    if (psRc.Length > 0)
    //    {
    //        psRc = ssRc;
    //        return 0;
    //    }
    //    while (sqlRs.Read())
    //    {
    //        pdEkp1 = Convert.ToDouble(sqlRs["ComEkp1"].ToString());
    //    }
    //    hsSqlHandle.sqlFileClose(sqlRs);
    //    pdDisc = pdEkp1;


    //    //Find CompDisc discount
    //    pdEkp1 = 0;
    //    sSql = "SELECT CompDisc.*";
    //    sSql += " FROM CompDisc";
    //    sSql += " WHERE CompDisc.ComAn = " + csQuote(ssComAn);
    //    sqlRs = hsSqlHandle.sqlFileOpen(sSql, sqlCnn, ref psRc);
    //    if (psRc.Length > 0)
    //    {
    //        psRc = ssRc;
    //        return 0;
    //    }
    //    while (sqlRs.Read())
    //    {
    //        pbIsxi = 1;
    //        if (csIsDate(sqlRs["CdiLixiDa"].ToString()))
    //        {
    //            pdNow = DateTime.Now.ToString("yyyyMMdd");
    //            pdDate = csDateDisp(sqlRs["CdiLixiDa"].ToString(), "yyyyMMdd");
    //            if (pdDate.CompareTo(pdNow) < 0)
    //            {
    //                pbIsxi = 0;
    //            }
    //        }
    //        if (pbIsxi == 1)
    //        {
    //            if (psPrgAn.Length > 0 && sqlRs["PrgAn"].ToString() == psPrgAn)
    //            {
    //                if (Convert.ToDouble(sqlRs["CdiPerc"]) > 0)
    //                {
    //                    pdEkp1 = Convert.ToDouble(sqlRs["CdiPerc"].ToString());
    //                }
    //            }

    //            if (psPrcAn.Length > 0 && sqlRs["PrcAn"].ToString() == psPrcAn)
    //            {
    //                if (Convert.ToDouble(sqlRs["CdiPerc"]) > 0)
    //                {
    //                    pdEkp1 = Convert.ToDouble(sqlRs["CdiPerc"].ToString());
    //                }
    //            }
    //        }


    //        if (pdDisc < pdEkp1)
    //        {
    //            pdDisc = pdEkp1;
    //        }
    //    }
    //    hsSqlHandle.sqlFileClose(sqlRs);

    //    return pdDisc;
    //}

    


    public String csSqlIn(Object ssInput)
    {
        String psEx;
        String sValue = "";
        String strInput = "";
        long lLen = 0;
        try
        {
            if (ssInput == System.DBNull.Value)
            {
                sValue = "''";
            }
            else
            {
                sValue = Convert.ToString(ssInput) + "";

                strInput = Convert.ToString(sValue+"".Replace("'", " ")).Trim();
                lLen = strInput.Length;
                sValue = "";
                for (int i = 1; i <= lLen; i++)
                {
                    if (csMid(strInput, i, 1) == ",")
                    {
                        sValue = sValue + "','";
                    }
                    else
                    {
                        sValue = sValue + csMid(strInput, i, 1);
                    }
                }
                sValue = "('" + sValue + "" + "')";
            }
        }
        catch (Exception ex)
        {
            psEx = ex.Message;
            sValue = "''";
        }
        return sValue;
    }


    public int csWordCount(string strIn, string chrDelimit)
    {
        int intWordCount = 0;
        int intPos = 0;

        intWordCount = 1;
        strIn.IndexOf(chrDelimit);
        intPos = strIn.IndexOf(chrDelimit);
        while (intPos > 0)
        {
            intWordCount = intWordCount + 1;
            intPos = strIn.IndexOf(chrDelimit, intPos + 1);
        }
        return intWordCount;
    }


    public String csBanner(String ssPath)
    {
        String psText;

        psText = "";
        try
        {
            if (System.IO.File.Exists(ssPath))
            {
                StreamReader streamReader = new StreamReader(ssPath, System.Text.Encoding.GetEncoding(1253));
                psText = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }
        catch (FileNotFoundException e)
        {
            psText = e.ToString();
        }

        return psText;
    }


    public String csMess(String ssText, String sbGreEng)
    {
        String psRes = "";

        if (csWordCount(ssText, "|") == 2)
        {
            if (sbGreEng == "2")
            {
                psRes = csSplit(ssText, 2, "|");
            }
            else
            {
                psRes = csSplit(ssText, 1, "|");
            }
        }
        else
        {
            switch (ssText)
            {
                case "CannotConnect":
                    if (sbGreEng == "1") psRes = "Αδύνατη η σύνδεση με την DataBase"; else psRes = "Cannot connect to Database"; break;
                case "CannotDisconnect":
                    if (sbGreEng == "1") psRes = "Αδύνατη η αποσύνδεση από την DataBase"; else psRes = "Cannot disconnect from Database"; break;
                case "NoAccessRigths":
                    if (sbGreEng == "1") psRes = "Δεν έχετε πρόσβαση στην επιλογή"; else psRes = "No Access rights"; break;
                case "FileNotFound":
                    if (sbGreEng == "1") psRes = "Αρχείο είναι ανύπαρκτο"; else psRes = "File not found"; break;
                case "RecordNotFound":
                    if (sbGreEng == "1") psRes = "Ανύπαρκος κωδικός"; else psRes = "Record not found"; break;

                case "NoUpdate":
                    if (sbGreEng == "1") psRes = "Χωρίς ενημέρωση"; else psRes = "No Update"; break;
                case "Found":
                    if (sbGreEng == "1") psRes = "Βρέθηκαν"; else psRes = "Found"; break;
                case "Records":
                    if (sbGreEng == "1") psRes = "Εγγραφές"; else psRes = "Records"; break;
                case "TotalRecords":
                    if (sbGreEng == "1") psRes = "Σύνολο εγγραφών"; else psRes = "Total records"; break;
                case "Updated":
                    if (sbGreEng == "1") psRes = "Ενημερώθηκαν"; else psRes = "Updated"; break;

                case "ProductUpdate":
                    if (sbGreEng == "1") psRes = "Ενημέρωση ειδών"; else psRes = "Item Update"; break;
                case "ProdKataskUpdate":
                    if (sbGreEng == "1") psRes = "Ενημέρωση Κατασκευαστών ειδών"; else psRes = "Item Maker Update"; break;
                case "ProdGroupUpdate":
                    if (sbGreEng == "1") psRes = "Ενημέρωση Ομάδων ειδών"; else psRes = "Item Group Update"; break;
                case "ProdCatUpdate":
                    if (sbGreEng == "1") psRes = "Ενημέρωση Κατηγοριών ειδών"; else psRes = "Item Category Update"; break;
                case "ProdScaUpdate":
                    if (sbGreEng == "1") psRes = "Ενημέρωση Υποκατηγοριών ειδών"; else psRes = "Item Subcategory Update"; break;
                case "ProdImageUpate":
                    if (sbGreEng == "1") psRes = "Ενημέρωση Φωτογραφιών ειδών"; else psRes = "Item Photos Update"; break;
                default:
                    psRes = ssText; break;
            }
        }
        return psRes;
    }



}
