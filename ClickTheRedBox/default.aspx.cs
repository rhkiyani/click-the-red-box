using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace ClickTheRedBox
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                level0.Visible = true;
                //global = new Global();
                Session["score"] = 0;
                Session["lastRedButton"] = "";
                displayHighScores();
            }
            else
            {

            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender);

            //lblScore.Text = btn.ID;
            int currLvl = Convert.ToInt32(btn.CommandArgument.ToString()) + 1;
            Random r = new Random();
            int random = 0;
            int score = 0;
            string[] colors = new string[126];

            colors[0] = "#003366";
            colors[1] = "#336699";
            colors[2] = "#3366cc";
            colors[3] = "#003399"; //
            colors[4] = "#000099"; //
            colors[5] = "#0000cc"; //
            colors[6] = "#000066";//
            colors[7] = "#006666";//
            colors[8] = "#006699";//
            colors[9] = "#0099cc";//
            colors[10] = "#0066cc";//
            colors[11] = "#0033cc";//
            colors[12] = "#0000ff";//
            colors[13] = "#3333ff";//
            colors[14] = "#333399";//
            colors[15] = "#669999";//
            colors[16] = "#009999";//
            colors[17] = "#33cccc";//
            colors[18] = "#00ccff";//
            colors[19] = "#0099ff";//
            colors[20] = "#0066ff";//
            colors[21] = "#3366ff";//
            colors[22] = "#3333cc";//
            colors[23] = "#666699";//
            colors[24] = "#339966";//
            colors[25] = "#00cc99";//
            colors[26] = "#00ffcc";//
            colors[27] = "#00ffff";//
            colors[28] = "#33ccff";//
            colors[29] = "#3399ff";//
            colors[30] = "#6699ff";//
            colors[31] = "#6666ff";//
            colors[32] = "#6600ff";//
            colors[33] = "#6600cc";//
            colors[34] = "#339933";//
            colors[35] = "#00cc66";//
            colors[36] = "#00ff99";//
            colors[37] = "#66ffcc";//
            colors[38] = "#66ffff";//
            colors[39] = "#66ccff";//
            colors[40] = "#99ccff";//
            colors[41] = "#9999ff";//
            colors[42] = "#9966ff";//
            colors[43] = "#9933ff";//
            colors[44] = "#9900ff";//
            colors[45] = "#006600";//
            colors[46] = "#00cc00";//
            colors[47] = "#00ff00";//
            colors[48] = "#66ff99";//
            colors[49] = "#99ffcc";//
            colors[50] = "#ccffff";//
            colors[51] = "#ccccff";//
            colors[52] = "#cc99ff";//
            colors[53] = "#cc66ff";//
            colors[54] = "#cc33ff";//
            colors[55] = "#cc00ff";//
            colors[56] = "#9900cc";//
            colors[57] = "#003300";//
            colors[58] = "#009933";//
            colors[59] = "#33cc33";//
            colors[60] = "#66ff66";//
            colors[61] = "#99ff99";//
            colors[62] = "#ccffcc";//
            colors[63] = "#ffffff";//
            colors[64] = "#ffccff";//
            colors[65] = "#ff99ff";//
            colors[66] = "#ff66ff";//
            colors[67] = "#ff00ff";//
            colors[68] = "#cc00cc";//
            colors[69] = "#660066";//
            colors[70] = "#336600";//
            colors[71] = "#009900";//
            colors[72] = "#66ff33";//
            colors[73] = "#99ff66";//
            colors[74] = "#ccff99";//
            colors[75] = "#ffffcc";//
            colors[76] = "#ffcccc";//
            colors[77] = "#ff99cc";//
            colors[78] = "#ff66cc";//
            colors[79] = "#ff33cc";//
            colors[80] = "#cc0099";//
            colors[81] = "#993399";//
            colors[82] = "#333300";//
            colors[83] = "#669900";//
            colors[84] = "#99ff33";//
            colors[85] = "#ccff66";//
            colors[86] = "#336699";//
            colors[87] = "#ffcc99";//
            colors[88] = "#ff9999";//
            colors[89] = "#ff6699";//
            colors[90] = "#ff3399";//
            colors[91] = "#cc3399";//
            colors[92] = "#990099";//
            colors[93] = "#666633";//
            colors[94] = "#99cc00";//
            colors[95] = "#ccff33";//
            colors[96] = "#ffff66";//
            colors[97] = "#ffcc66";//
            colors[98] = "#ff9966";//
            colors[99] = "#ff6666";//
            colors[100] = "#ff0066";//
            colors[101] = "#cc6699";//
            colors[102] = "#993366";//
            colors[103] = "#999966";//
            colors[104] = "#cccc00";//
            colors[105] = "#ffff00";//
            colors[106] = "#ffcc00";//
            colors[107] = "#ff9933";//
            colors[108] = "#ff6600";//
            colors[109] = "#ff5050";//
            colors[110] = "#cc0066";//
            colors[111] = "#660033";//
            colors[112] = "#996633";//
            colors[113] = "#cc9900";//
            colors[114] = "#ff9900";//
            colors[115] = "#cc6600";//
            colors[116] = "#ff3300";//
            colors[117] = "#cc0000";//
            colors[118] = "#990033";//
            colors[119] = "#663300";//
            colors[120] = "#996600";//
            colors[121] = "#cc3300";//
            colors[122] = "#993300";//
            colors[123] = "#990000";//
            colors[124] = "#800000";//
            colors[125] = "#993333";//
            

            Shuffle(colors);

            switch (currLvl)
            {
                case 1:
                    level0.Visible = false;
                    level1.Visible = true;
                    button101.BackColor = Color.Red;
                    Session["lastRedButton"] = "button101";
                    Session["score"] = 0;
                    break;
                case 2:
                    //1 random color
                    //2 buttons
                    if (btn.ID == Session["lastRedButton"].ToString())
                    {
                        score = Convert.ToInt32(Session["score"]);
                        score++;
                        Session["score"] = score;
                    }
                    else
                    {
                        level1.Visible = false;
                        level99.Visible = true;
                        lblYourScore.Text = Session["score"].ToString();
                        Session["score"] = 0;
                        break;
                    }

                    button201.BackColor = ColorTranslator.FromHtml(colors[0]);
                    button202.BackColor = ColorTranslator.FromHtml(colors[1]);

                    random = r.Next(1, 3);

                    if (random == 1)
                    {
                        button201.BackColor = Color.Red;
                        Session["lastRedButton"] = "button201";
                    }
                    else
                    {
                        button202.BackColor = Color.Red;
                        Session["lastRedButton"] = "button202";
                    }

                    level1.Visible = false;
                    level2.Visible = true;
                    break;

                case 3:
                    //3 random colors
                    //4 buttons

                    if (btn.ID == Session["lastRedButton"].ToString())
                    {
                        score = Convert.ToInt32(Session["score"]);
                        score++;
                        Session["score"] = score;
                    }
                    else
                    {
                        level2.Visible = false;
                        level99.Visible = true;
                        lblYourScore.Text = Session["score"].ToString();
                        Session["score"] = 0;
                        break;
                    }

                    button301.BackColor = ColorTranslator.FromHtml(colors[0]);
                    button302.BackColor = ColorTranslator.FromHtml(colors[1]);
                    button303.BackColor = ColorTranslator.FromHtml(colors[2]);
                    button304.BackColor = ColorTranslator.FromHtml(colors[3]);

                    random = r.Next(1, 5);

                    if (random == 1)
                    {
                        button301.BackColor = Color.Red;
                        Session["lastRedButton"] = "button301";
                        //global.updateLastRedButton("button301");
                    }
                    else if (random == 2)
                    {
                        button302.BackColor = Color.Red;
                        Session["lastRedButton"] = "button302";
                        //global.updateLastRedButton("button302");
                    }
                    else if (random == 3)
                    {
                        button303.BackColor = Color.Red;
                        Session["lastRedButton"] = "button303";
                        //global.updateLastRedButton("button303");
                    }
                    else
                    {
                        button304.BackColor = Color.Red;
                        Session["lastRedButton"] = "button304";
                        //global.updateLastRedButton("button304");
                    }

                    level2.Visible = false;
                    level3.Visible = true;

                    break;

                case 4:
                    //5 random colors
                    //6 buttons

                    if (btn.ID == Session["lastRedButton"].ToString())
                    {
                        score = Convert.ToInt32(Session["score"]);
                        score++;
                        Session["score"] = score;
                    }
                    else
                    {
                        level3.Visible = false;
                        level99.Visible = true;
                        lblYourScore.Text = Session["score"].ToString();
                        Session["score"] = 0;
                        break;
                    }

                    button401.BackColor = ColorTranslator.FromHtml(colors[0]);
                    button402.BackColor = ColorTranslator.FromHtml(colors[1]);
                    button403.BackColor = ColorTranslator.FromHtml(colors[2]);
                    button404.BackColor = ColorTranslator.FromHtml(colors[3]);
                    button405.BackColor = ColorTranslator.FromHtml(colors[4]);
                    button406.BackColor = ColorTranslator.FromHtml(colors[5]);

                    random = r.Next(1, 7);

                    if (random == 1)
                    {
                        button401.BackColor = Color.Red;
                        Session["lastRedButton"] = "button401";
                    }
                    else if (random == 2)
                    {
                        button402.BackColor = Color.Red;
                        Session["lastRedButton"] = "button402";
                    }
                    else if (random == 3)
                    {
                        button403.BackColor = Color.Red;
                        Session["lastRedButton"] = "button403";
                    }
                    else if (random == 4)
                    {
                        button404.BackColor = Color.Red;
                        Session["lastRedButton"] = "button404";
                    }
                    else if (random == 5)
                    {
                        button405.BackColor = Color.Red;
                        Session["lastRedButton"] = "button405";
                    }
                    else
                    {
                        button406.BackColor = Color.Red;
                        Session["lastRedButton"] = "button406";
                    }

                    level3.Visible = false;
                    level4.Visible = true;
                    break;

                case 5:
                    //8 random colors
                    //9 buttons

                    if (btn.ID == Session["lastRedButton"].ToString())
                    {
                        score = Convert.ToInt32(Session["score"]);
                        score++;
                        Session["score"] = score;
                    }
                    else
                    {
                        level4.Visible = false;
                        level99.Visible = true;
                        lblYourScore.Text = Session["score"].ToString();
                        Session["score"] = 0;
                        break;
                    }

                    button501.BackColor = ColorTranslator.FromHtml(colors[0]);
                    button502.BackColor = ColorTranslator.FromHtml(colors[1]);
                    button503.BackColor = ColorTranslator.FromHtml(colors[2]);
                    button504.BackColor = ColorTranslator.FromHtml(colors[3]);
                    button505.BackColor = ColorTranslator.FromHtml(colors[4]);
                    button506.BackColor = ColorTranslator.FromHtml(colors[5]);
                    button507.BackColor = ColorTranslator.FromHtml(colors[6]);
                    button508.BackColor = ColorTranslator.FromHtml(colors[7]);
                    button509.BackColor = ColorTranslator.FromHtml(colors[8]);

                    random = r.Next(1, 10);

                    if (random == 1)
                    {
                        button501.BackColor = Color.Red;
                        Session["lastRedButton"] = "button501";
                    }
                    else if (random == 2)
                    {
                        button502.BackColor = Color.Red;
                        Session["lastRedButton"] = "button502";
                    }
                    else if (random == 3)
                    {
                        button503.BackColor = Color.Red;
                        Session["lastRedButton"] = "button503";
                    }
                    else if (random == 4)
                    {
                        button504.BackColor = Color.Red;
                        Session["lastRedButton"] = "button504";
                    }
                    else if (random == 5)
                    {
                        button505.BackColor = Color.Red;
                        Session["lastRedButton"] = "button505";
                    }
                    else if (random == 6)
                    {
                        button506.BackColor = Color.Red;
                        Session["lastRedButton"] = "button506";
                    }
                    else if (random == 7)
                    {
                        button507.BackColor = Color.Red;
                        Session["lastRedButton"] = "button507";
                    }
                    else if (random == 8)
                    {
                        button508.BackColor = Color.Red;
                        Session["lastRedButton"] = "button508";
                    }
                    else
                    {
                        button509.BackColor = Color.Red;
                        Session["lastRedButton"] = "button509";
                    }

                    level4.Visible = false;
                    level5.Visible = true;
                    break;
                case 6:
                    //17 random colors
                    //18 buttons

                    if (btn.ID == Session["lastRedButton"].ToString())
                    {
                        score = Convert.ToInt32(Session["score"]);
                        score++;
                        Session["score"] = score;
                    }
                    else
                    {
                        level5.Visible = false;
                        level99.Visible = true;
                        lblYourScore.Text = Session["score"].ToString();
                        Session["score"] = 0;
                        break;
                    }

                    button601.BackColor = ColorTranslator.FromHtml(colors[0]);
                    button602.BackColor = ColorTranslator.FromHtml(colors[1]);
                    button603.BackColor = ColorTranslator.FromHtml(colors[2]);
                    button604.BackColor = ColorTranslator.FromHtml(colors[3]);
                    button605.BackColor = ColorTranslator.FromHtml(colors[4]);
                    button606.BackColor = ColorTranslator.FromHtml(colors[5]);
                    button607.BackColor = ColorTranslator.FromHtml(colors[6]);
                    button608.BackColor = ColorTranslator.FromHtml(colors[7]);
                    button609.BackColor = ColorTranslator.FromHtml(colors[8]);
                    button610.BackColor = ColorTranslator.FromHtml(colors[9]);
                    button611.BackColor = ColorTranslator.FromHtml(colors[10]);
                    button612.BackColor = ColorTranslator.FromHtml(colors[11]);
                    button613.BackColor = ColorTranslator.FromHtml(colors[12]);
                    button614.BackColor = ColorTranslator.FromHtml(colors[13]);
                    button615.BackColor = ColorTranslator.FromHtml(colors[14]);
                    button616.BackColor = ColorTranslator.FromHtml(colors[15]);
                    button617.BackColor = ColorTranslator.FromHtml(colors[16]);
                    button618.BackColor = ColorTranslator.FromHtml(colors[17]);

                    random = r.Next(1, 19);

                    if (random == 1)
                    {
                        button601.BackColor = Color.Red;
                        Session["lastRedButton"] = "button601";
                    }
                    else if (random == 2)
                    {
                        button602.BackColor = Color.Red;
                        Session["lastRedButton"] = "button602";
                    }
                    else if (random == 3)
                    {
                        button603.BackColor = Color.Red;
                        Session["lastRedButton"] = "button503";
                    }
                    else if (random == 4)
                    {
                        button604.BackColor = Color.Red;
                        Session["lastRedButton"] = "button604";
                    }
                    else if (random == 5)
                    {
                        button605.BackColor = Color.Red;
                        Session["lastRedButton"] = "button605";
                    }
                    else if (random == 6)
                    {
                        button606.BackColor = Color.Red;
                        Session["lastRedButton"] = "button606";
                    }
                    else if (random == 7)
                    {
                        button607.BackColor = Color.Red;
                        Session["lastRedButton"] = "button607";
                    }
                    else if (random == 8)
                    {
                        button608.BackColor = Color.Red;
                        Session["lastRedButton"] = "button608";
                    }
                    else if (random == 9)
                    {
                        button609.BackColor = Color.Red;
                        Session["lastRedButton"] = "button609";
                    }
                    else if (random == 10)
                    {
                        button610.BackColor = Color.Red;
                        Session["lastRedButton"] = "button610";
                    }
                    else if (random == 11)
                    {
                        button611.BackColor = Color.Red;
                        Session["lastRedButton"] = "button611";
                    }
                    else if (random == 12)
                    {
                        button612.BackColor = Color.Red;
                        Session["lastRedButton"] = "button612";
                    }
                    else if (random == 13)
                    {
                        button613.BackColor = Color.Red;
                        Session["lastRedButton"] = "button613";
                    }
                    else if (random == 14)
                    {
                        button614.BackColor = Color.Red;
                        Session["lastRedButton"] = "button614";
                    }
                    else if (random == 15)
                    {
                        button615.BackColor = Color.Red;
                        Session["lastRedButton"] = "button615";
                    }
                    else if (random == 16)
                    {
                        button616.BackColor = Color.Red;
                        Session["lastRedButton"] = "button616";
                    }
                    else if (random == 17)
                    {
                        button617.BackColor = Color.Red;
                        Session["lastRedButton"] = "button617";
                    }
                    else
                    {
                        button618.BackColor = Color.Red;
                        Session["lastRedButton"] = "button618";
                    }

                    level5.Visible = false;
                    level6.Visible = true;
                    break;
                case 7:
                    //35 random colors
                    //36 buttons

                    if (btn.ID == Session["lastRedButton"].ToString())
                    {
                        score = Convert.ToInt32(Session["score"]);
                        score++;
                        Session["score"] = score;
                    }
                    else
                    {
                        level6.Visible = false;
                        level99.Visible = true;
                        lblYourScore.Text = Session["score"].ToString();
                        Session["score"] = 0;
                        break;
                    }

                    button701.BackColor = ColorTranslator.FromHtml(colors[0]);
                    button702.BackColor = ColorTranslator.FromHtml(colors[1]);
                    button703.BackColor = ColorTranslator.FromHtml(colors[2]);
                    button704.BackColor = ColorTranslator.FromHtml(colors[3]);
                    button705.BackColor = ColorTranslator.FromHtml(colors[4]);
                    button706.BackColor = ColorTranslator.FromHtml(colors[5]);
                    button707.BackColor = ColorTranslator.FromHtml(colors[6]);
                    button708.BackColor = ColorTranslator.FromHtml(colors[7]);
                    button709.BackColor = ColorTranslator.FromHtml(colors[8]);
                    button710.BackColor = ColorTranslator.FromHtml(colors[9]);
                    button711.BackColor = ColorTranslator.FromHtml(colors[10]);
                    button712.BackColor = ColorTranslator.FromHtml(colors[11]);
                    button713.BackColor = ColorTranslator.FromHtml(colors[12]);
                    button714.BackColor = ColorTranslator.FromHtml(colors[13]);
                    button715.BackColor = ColorTranslator.FromHtml(colors[14]);
                    button716.BackColor = ColorTranslator.FromHtml(colors[15]);
                    button717.BackColor = ColorTranslator.FromHtml(colors[16]);
                    button718.BackColor = ColorTranslator.FromHtml(colors[17]);
                    button719.BackColor = ColorTranslator.FromHtml(colors[18]);
                    button720.BackColor = ColorTranslator.FromHtml(colors[19]);
                    button721.BackColor = ColorTranslator.FromHtml(colors[20]);
                    button722.BackColor = ColorTranslator.FromHtml(colors[21]);
                    button723.BackColor = ColorTranslator.FromHtml(colors[22]);
                    button724.BackColor = ColorTranslator.FromHtml(colors[23]);
                    button725.BackColor = ColorTranslator.FromHtml(colors[24]);
                    button726.BackColor = ColorTranslator.FromHtml(colors[25]);
                    button727.BackColor = ColorTranslator.FromHtml(colors[26]);
                    button728.BackColor = ColorTranslator.FromHtml(colors[27]);
                    button729.BackColor = ColorTranslator.FromHtml(colors[28]);
                    button730.BackColor = ColorTranslator.FromHtml(colors[29]);
                    button731.BackColor = ColorTranslator.FromHtml(colors[30]);
                    button732.BackColor = ColorTranslator.FromHtml(colors[31]);
                    button733.BackColor = ColorTranslator.FromHtml(colors[32]);
                    button734.BackColor = ColorTranslator.FromHtml(colors[33]);
                    button735.BackColor = ColorTranslator.FromHtml(colors[34]);
                    button736.BackColor = ColorTranslator.FromHtml(colors[35]);

                    random = r.Next(1, 37);
                    if (random == 1)
                    {
                        button701.BackColor = Color.Red;
                        Session["lastRedButton"] = "button701";
                    }
                    else if (random == 2)
                    {
                        button702.BackColor = Color.Red;
                        Session["lastRedButton"] = "button702";
                    }
                    else if (random == 3)
                    {
                        button703.BackColor = Color.Red;
                        Session["lastRedButton"] = "button703";
                    }
                    else if (random == 4)
                    {
                        button704.BackColor = Color.Red;
                        Session["lastRedButton"] = "button704";
                    }
                    else if (random == 5)
                    {
                        button705.BackColor = Color.Red;
                        Session["lastRedButton"] = "button705";
                    }
                    else if (random == 6)
                    {
                        button706.BackColor = Color.Red;
                        Session["lastRedButton"] = "button706";
                    }
                    else if (random == 7)
                    {
                        button707.BackColor = Color.Red;
                        Session["lastRedButton"] = "button707";
                    }
                    else if (random == 8)
                    {
                        button708.BackColor = Color.Red;
                        Session["lastRedButton"] = "button708";
                    }
                    else if (random == 9)
                    {
                        button709.BackColor = Color.Red;
                        Session["lastRedButton"] = "button709";
                    }
                    else if (random == 10)
                    {
                        button710.BackColor = Color.Red;
                        Session["lastRedButton"] = "button710";
                    }
                    else if (random == 11)
                    {
                        button711.BackColor = Color.Red;
                        Session["lastRedButton"] = "button711";
                    }
                    else if (random == 12)
                    {
                        button712.BackColor = Color.Red;
                        Session["lastRedButton"] = "button712";
                    }
                    else if (random == 13)
                    {
                        button713.BackColor = Color.Red;
                        Session["lastRedButton"] = "button713";
                    }
                    else if (random == 14)
                    {
                        button714.BackColor = Color.Red;
                        Session["lastRedButton"] = "button714";
                    }
                    else if (random == 15)
                    {
                        button715.BackColor = Color.Red;
                        Session["lastRedButton"] = "button715";
                    }
                    else if (random == 16)
                    {
                        button716.BackColor = Color.Red;
                        Session["lastRedButton"] = "button716";
                    }
                    else if (random == 17)
                    {
                        button717.BackColor = Color.Red;
                        Session["lastRedButton"] = "button717";
                    }
                    else if (random == 18)
                    {
                        button718.BackColor = Color.Red;
                        Session["lastRedButton"] = "button718";
                    }
                    else if (random == 19)
                    {
                        button719.BackColor = Color.Red;
                        Session["lastRedButton"] = "button719";
                    }
                    else if (random == 20)
                    {
                        button720.BackColor = Color.Red;
                        Session["lastRedButton"] = "button720";
                    }
                    else if (random == 21)
                    {
                        button721.BackColor = Color.Red;
                        Session["lastRedButton"] = "button721";
                    }
                    else if (random == 22)
                    {
                        button722.BackColor = Color.Red;
                        Session["lastRedButton"] = "button722";
                    }
                    else if (random == 23)
                    {
                        button723.BackColor = Color.Red;
                        Session["lastRedButton"] = "button723";
                    }
                    else if (random == 24)
                    {
                        button724.BackColor = Color.Red;
                        Session["lastRedButton"] = "button724";
                    }
                    else if (random == 25)
                    {
                        button725.BackColor = Color.Red;
                        Session["lastRedButton"] = "button725";
                    }
                    else if (random == 26)
                    {
                        button726.BackColor = Color.Red;
                        Session["lastRedButton"] = "button726";
                    }
                    else if (random == 27)
                    {
                        button727.BackColor = Color.Red;
                        Session["lastRedButton"] = "button727";
                    }
                    else if (random == 28)
                    {
                        button728.BackColor = Color.Red;
                        Session["lastRedButton"] = "button728";
                    }
                    else if (random == 29)
                    {
                        button729.BackColor = Color.Red;
                        Session["lastRedButton"] = "button729";
                    }
                    else if (random == 30)
                    {
                        button730.BackColor = Color.Red;
                        Session["lastRedButton"] = "button730";
                    }
                    else if (random == 31)
                    {
                        button731.BackColor = Color.Red;
                        Session["lastRedButton"] = "button731";
                    }
                    else if (random == 32)
                    {
                        button732.BackColor = Color.Red;
                        Session["lastRedButton"] = "button732";
                    }
                    else if (random == 33)
                    {
                        button733.BackColor = Color.Red;
                        Session["lastRedButton"] = "button733";
                    }
                    else if (random == 34)
                    {
                        button734.BackColor = Color.Red;
                        Session["lastRedButton"] = "button734";
                    }
                    else if (random == 35)
                    {
                        button735.BackColor = Color.Red;
                        Session["lastRedButton"] = "button735";
                    }
                    else
                    {
                        button736.BackColor = Color.Red;
                        Session["lastRedButton"] = "button736";
                    }

                    level6.Visible = false;
                    level7.Visible = true;
                    break;
                case 8:

                    if (btn.ID == Session["lastRedButton"].ToString())
                    {
                        score = Convert.ToInt32(Session["score"]);
                        score++;
                        Session["score"] = score;
                    }
                    else
                    {
                        level7.Visible = false;
                        level99.Visible = true;
                        lblYourScore.Text = Session["score"].ToString();
                        Session["score"] = 0;
                        break;
                    }

                    button801.BackColor = ColorTranslator.FromHtml(colors[0]);
                    button802.BackColor = ColorTranslator.FromHtml(colors[1]);
                    button803.BackColor = ColorTranslator.FromHtml(colors[2]);
                    button804.BackColor = ColorTranslator.FromHtml(colors[3]);
                    button805.BackColor = ColorTranslator.FromHtml(colors[4]);
                    button806.BackColor = ColorTranslator.FromHtml(colors[5]);
                    button807.BackColor = ColorTranslator.FromHtml(colors[6]);
                    button808.BackColor = ColorTranslator.FromHtml(colors[7]);
                    button809.BackColor = ColorTranslator.FromHtml(colors[8]);
                    button810.BackColor = ColorTranslator.FromHtml(colors[9]);
                    button811.BackColor = ColorTranslator.FromHtml(colors[10]);
                    button812.BackColor = ColorTranslator.FromHtml(colors[11]);
                    button813.BackColor = ColorTranslator.FromHtml(colors[12]);
                    button814.BackColor = ColorTranslator.FromHtml(colors[13]);
                    button815.BackColor = ColorTranslator.FromHtml(colors[14]);
                    button816.BackColor = ColorTranslator.FromHtml(colors[15]);
                    button817.BackColor = ColorTranslator.FromHtml(colors[16]);
                    button818.BackColor = ColorTranslator.FromHtml(colors[17]);
                    button819.BackColor = ColorTranslator.FromHtml(colors[18]);
                    button820.BackColor = ColorTranslator.FromHtml(colors[19]);
                    button821.BackColor = ColorTranslator.FromHtml(colors[20]);
                    button822.BackColor = ColorTranslator.FromHtml(colors[21]);
                    button823.BackColor = ColorTranslator.FromHtml(colors[22]);
                    button824.BackColor = ColorTranslator.FromHtml(colors[23]);
                    button825.BackColor = ColorTranslator.FromHtml(colors[24]);
                    button826.BackColor = ColorTranslator.FromHtml(colors[25]);
                    button827.BackColor = ColorTranslator.FromHtml(colors[26]);
                    button828.BackColor = ColorTranslator.FromHtml(colors[27]);
                    button829.BackColor = ColorTranslator.FromHtml(colors[28]);
                    button830.BackColor = ColorTranslator.FromHtml(colors[29]);
                    button831.BackColor = ColorTranslator.FromHtml(colors[30]);
                    button832.BackColor = ColorTranslator.FromHtml(colors[31]);
                    button833.BackColor = ColorTranslator.FromHtml(colors[32]);
                    button834.BackColor = ColorTranslator.FromHtml(colors[33]);
                    button835.BackColor = ColorTranslator.FromHtml(colors[34]);
                    button836.BackColor = ColorTranslator.FromHtml(colors[35]);
                    button837.BackColor = ColorTranslator.FromHtml(colors[36]);
                    button838.BackColor = ColorTranslator.FromHtml(colors[37]);
                    button839.BackColor = ColorTranslator.FromHtml(colors[38]);
                    button840.BackColor = ColorTranslator.FromHtml(colors[39]);
                    button841.BackColor = ColorTranslator.FromHtml(colors[40]);
                    button842.BackColor = ColorTranslator.FromHtml(colors[41]);
                    button843.BackColor = ColorTranslator.FromHtml(colors[42]);
                    button844.BackColor = ColorTranslator.FromHtml(colors[43]);
                    button845.BackColor = ColorTranslator.FromHtml(colors[44]);
                    button846.BackColor = ColorTranslator.FromHtml(colors[45]);
                    button847.BackColor = ColorTranslator.FromHtml(colors[46]);
                    button848.BackColor = ColorTranslator.FromHtml(colors[47]);
                    button849.BackColor = ColorTranslator.FromHtml(colors[48]);
                    button850.BackColor = ColorTranslator.FromHtml(colors[49]);
                    button851.BackColor = ColorTranslator.FromHtml(colors[50]);
                    button852.BackColor = ColorTranslator.FromHtml(colors[51]);
                    button853.BackColor = ColorTranslator.FromHtml(colors[52]);
                    button854.BackColor = ColorTranslator.FromHtml(colors[53]);
                    button855.BackColor = ColorTranslator.FromHtml(colors[54]);
                    button856.BackColor = ColorTranslator.FromHtml(colors[55]);
                    button857.BackColor = ColorTranslator.FromHtml(colors[56]);
                    button858.BackColor = ColorTranslator.FromHtml(colors[57]);
                    button859.BackColor = ColorTranslator.FromHtml(colors[58]);
                    button860.BackColor = ColorTranslator.FromHtml(colors[59]);
                    button861.BackColor = ColorTranslator.FromHtml(colors[60]);
                    button862.BackColor = ColorTranslator.FromHtml(colors[61]);
                    button863.BackColor = ColorTranslator.FromHtml(colors[62]);
                    button864.BackColor = ColorTranslator.FromHtml(colors[63]);
                    button865.BackColor = ColorTranslator.FromHtml(colors[64]);
                    button866.BackColor = ColorTranslator.FromHtml(colors[65]);
                    button867.BackColor = ColorTranslator.FromHtml(colors[66]);
                    button868.BackColor = ColorTranslator.FromHtml(colors[67]);
                    button869.BackColor = ColorTranslator.FromHtml(colors[68]);
                    button870.BackColor = ColorTranslator.FromHtml(colors[69]);
                    button871.BackColor = ColorTranslator.FromHtml(colors[70]);
                    button872.BackColor = ColorTranslator.FromHtml(colors[71]);

                    random = r.Next(1, 73);

                    if (random == 1)
                    {
                        button801.BackColor = Color.Red;
                        Session["lastRedButton"] = "button801";
                    }
                    else if (random == 2)
                    {
                        button802.BackColor = Color.Red;
                        Session["lastRedButton"] = "button802";
                    }
                    else if (random == 3)
                    {
                        button803.BackColor = Color.Red;
                        Session["lastRedButton"] = "button803";
                    }
                    else if (random == 4)
                    {
                        button804.BackColor = Color.Red;
                        Session["lastRedButton"] = "button804";
                    }
                    else if (random == 5)
                    {
                        button805.BackColor = Color.Red;
                        Session["lastRedButton"] = "button805";
                    }
                    else if (random == 6)
                    {
                        button806.BackColor = Color.Red;
                        Session["lastRedButton"] = "button806";
                    }
                    else if (random == 7)
                    {
                        button807.BackColor = Color.Red;
                        Session["lastRedButton"] = "button807";
                    }
                    else if (random == 8)
                    {
                        button808.BackColor = Color.Red;
                        Session["lastRedButton"] = "button808";
                    }
                    else if (random == 9)
                    {
                        button809.BackColor = Color.Red;
                        Session["lastRedButton"] = "button809";
                    }
                    else if (random == 10)
                    {
                        button810.BackColor = Color.Red;
                        Session["lastRedButton"] = "button810";
                    }
                    else if (random == 11)
                    {
                        button811.BackColor = Color.Red;
                        Session["lastRedButton"] = "button811";
                    }
                    else if (random == 12)
                    {
                        button812.BackColor = Color.Red;
                        Session["lastRedButton"] = "button812";
                    }
                    else if (random == 13)
                    {
                        button813.BackColor = Color.Red;
                        Session["lastRedButton"] = "button813";
                    }
                    else if (random == 14)
                    {
                        button814.BackColor = Color.Red;
                        Session["lastRedButton"] = "button814";
                    }
                    else if (random == 15)
                    {
                        button815.BackColor = Color.Red;
                        Session["lastRedButton"] = "button815";
                    }
                    else if (random == 16)
                    {
                        button816.BackColor = Color.Red;
                        Session["lastRedButton"] = "button816";
                    }
                    else if (random == 17)
                    {
                        button817.BackColor = Color.Red;
                        Session["lastRedButton"] = "button817";
                    }
                    else if (random == 18)
                    {
                        button818.BackColor = Color.Red;
                        Session["lastRedButton"] = "button818";
                    }
                    else if (random == 19)
                    {
                        button819.BackColor = Color.Red;
                        Session["lastRedButton"] = "button819";
                    }
                    else if (random == 20)
                    {
                        button820.BackColor = Color.Red;
                        Session["lastRedButton"] = "button820";
                    }
                    else if (random == 21)
                    {
                        button821.BackColor = Color.Red;
                        Session["lastRedButton"] = "button821";
                    }
                    else if (random == 22)
                    {
                        button822.BackColor = Color.Red;
                        Session["lastRedButton"] = "button822";
                    }
                    else if (random == 23)
                    {
                        button823.BackColor = Color.Red;
                        Session["lastRedButton"] = "button823";
                    }
                    else if (random == 24)
                    {
                        button824.BackColor = Color.Red;
                        Session["lastRedButton"] = "button824";
                    }
                    else if (random == 25)
                    {
                        button825.BackColor = Color.Red;
                        Session["lastRedButton"] = "button825";
                    }
                    else if (random == 26)
                    {
                        button826.BackColor = Color.Red;
                        Session["lastRedButton"] = "button826";
                    }
                    else if (random == 27)
                    {
                        button827.BackColor = Color.Red;
                        Session["lastRedButton"] = "button827";
                    }
                    else if (random == 28)
                    {
                        button828.BackColor = Color.Red;
                        Session["lastRedButton"] = "button828";
                    }
                    else if (random == 29)
                    {
                        button829.BackColor = Color.Red;
                        Session["lastRedButton"] = "button829";
                    }
                    else if (random == 30)
                    {
                        button830.BackColor = Color.Red;
                        Session["lastRedButton"] = "button830";
                    }
                    else if (random == 31)
                    {
                        button831.BackColor = Color.Red;
                        Session["lastRedButton"] = "button831";
                    }
                    else if (random == 32)
                    {
                        button832.BackColor = Color.Red;
                        Session["lastRedButton"] = "button832";
                    }
                    else if (random == 33)
                    {
                        button833.BackColor = Color.Red;
                        Session["lastRedButton"] = "button833";
                    }
                    else if (random == 34)
                    {
                        button834.BackColor = Color.Red;
                        Session["lastRedButton"] = "button834";
                    }
                    else if (random == 35)
                    {
                        button835.BackColor = Color.Red;
                        Session["lastRedButton"] = "button835";
                    }
                    else if (random == 36)
                    {
                        button836.BackColor = Color.Red;
                        Session["lastRedButton"] = "button836";
                    }
                    else if (random == 37)
                    {
                        button837.BackColor = Color.Red;
                        Session["lastRedButton"] = "button837";
                    }
                    else if (random == 38)
                    {
                        button838.BackColor = Color.Red;
                        Session["lastRedButton"] = "button838";
                    }
                    else if (random == 39)
                    {
                        button839.BackColor = Color.Red;
                        Session["lastRedButton"] = "button839";
                    }
                    else if (random == 40)
                    {
                        button840.BackColor = Color.Red;
                        Session["lastRedButton"] = "button840";
                    }
                    else if (random == 41)
                    {
                        button841.BackColor = Color.Red;
                        Session["lastRedButton"] = "button841";
                    }
                    else if (random == 42)
                    {
                        button842.BackColor = Color.Red;
                        Session["lastRedButton"] = "button842";
                    }
                    else if (random == 43)
                    {
                        button843.BackColor = Color.Red;
                        Session["lastRedButton"] = "button843";
                    }
                    else if (random == 44)
                    {
                        button844.BackColor = Color.Red;
                        Session["lastRedButton"] = "button844";
                    }
                    else if (random == 45)
                    {
                        button845.BackColor = Color.Red;
                        Session["lastRedButton"] = "button845";
                    }
                    else if (random == 46)
                    {
                        button846.BackColor = Color.Red;
                        Session["lastRedButton"] = "button846";
                    }
                    else if (random == 47)
                    {
                        button847.BackColor = Color.Red;
                        Session["lastRedButton"] = "button847";
                    }
                    else if (random == 48)
                    {
                        button848.BackColor = Color.Red;
                        Session["lastRedButton"] = "button848";
                    }
                    else if (random == 49)
                    {
                        button849.BackColor = Color.Red;
                        Session["lastRedButton"] = "button849";
                    }
                    else if (random == 50)
                    {
                        button850.BackColor = Color.Red;
                        Session["lastRedButton"] = "button850";
                    }
                    else if (random == 51)
                    {
                        button851.BackColor = Color.Red;
                        Session["lastRedButton"] = "button851";
                    }
                    else if (random == 52)
                    {
                        button852.BackColor = Color.Red;
                        Session["lastRedButton"] = "button852";
                    }
                    else if (random == 53)
                    {
                        button853.BackColor = Color.Red;
                        Session["lastRedButton"] = "button853";
                    }
                    else if (random == 54)
                    {
                        button854.BackColor = Color.Red;
                        Session["lastRedButton"] = "button854";
                    }
                    else if (random == 55)
                    {
                        button855.BackColor = Color.Red;
                        Session["lastRedButton"] = "button855";
                    }
                    else if (random == 56)
                    {
                        button856.BackColor = Color.Red;
                        Session["lastRedButton"] = "button856";
                    }
                    else if (random == 57)
                    {
                        button857.BackColor = Color.Red;
                        Session["lastRedButton"] = "button857";
                    }
                    else if (random == 58)
                    {
                        button858.BackColor = Color.Red;
                        Session["lastRedButton"] = "button858";
                    }
                    else if (random == 59)
                    {
                        button859.BackColor = Color.Red;
                        Session["lastRedButton"] = "button859";
                    }
                    else if (random == 60)
                    {
                        button860.BackColor = Color.Red;
                        Session["lastRedButton"] = "button860";
                    }
                    else if (random == 61)
                    {
                        button861.BackColor = Color.Red;
                        Session["lastRedButton"] = "button861";
                    }
                    else if (random == 62)
                    {
                        button862.BackColor = Color.Red;
                        Session["lastRedButton"] = "button862";
                    }
                    else if (random == 63)
                    {
                        button863.BackColor = Color.Red;
                        Session["lastRedButton"] = "button863";
                    }
                    else if (random == 64)
                    {
                        button864.BackColor = Color.Red;
                        Session["lastRedButton"] = "button864";
                    }
                    else if (random == 65)
                    {
                        button865.BackColor = Color.Red;
                        Session["lastRedButton"] = "button865";
                    }
                    else if (random == 66)
                    {
                        button866.BackColor = Color.Red;
                        Session["lastRedButton"] = "button866";
                    }
                    else if (random == 67)
                    {
                        button867.BackColor = Color.Red;
                        Session["lastRedButton"] = "button867";
                    }
                    else if (random == 68)
                    {
                        button868.BackColor = Color.Red;
                        Session["lastRedButton"] = "button868";
                    }
                    else if (random == 69)
                    {
                        button869.BackColor = Color.Red;
                        Session["lastRedButton"] = "button869";
                    }
                    else if (random == 70)
                    {
                        button870.BackColor = Color.Red;
                        Session["lastRedButton"] = "button870";
                    }
                    else if (random == 71)
                    {
                        button871.BackColor = Color.Red;
                        Session["lastRedButton"] = "button871";
                    }
                    else
                    {
                        button872.BackColor = Color.Red;
                        Session["lastRedButton"] = "button872";
                    }

                    level7.Visible = false;
                    level8.Visible = true;
                    break;
                case 9:
                    if (btn.ID == Session["lastRedButton"].ToString())
                    {
                        score = Convert.ToInt32(Session["score"]);
                        score++;
                        Session["score"] = score;
                    }
                    else
                    {
                        level8.Visible = false;
                        level99.Visible = true;
                        lblYourScore.Text = Session["score"].ToString();
                        Session["score"] = 0;
                        break;
                    }

                    button901.BackColor = ColorTranslator.FromHtml(colors[0]);
                    button902.BackColor = ColorTranslator.FromHtml(colors[1]);
                    button903.BackColor = ColorTranslator.FromHtml(colors[2]);
                    button904.BackColor = ColorTranslator.FromHtml(colors[3]);
                    button905.BackColor = ColorTranslator.FromHtml(colors[4]);
                    button906.BackColor = ColorTranslator.FromHtml(colors[5]);
                    button907.BackColor = ColorTranslator.FromHtml(colors[6]);
                    button908.BackColor = ColorTranslator.FromHtml(colors[7]);
                    button909.BackColor = ColorTranslator.FromHtml(colors[8]);
                    button910.BackColor = ColorTranslator.FromHtml(colors[9]);
                    button911.BackColor = ColorTranslator.FromHtml(colors[10]);
                    button912.BackColor = ColorTranslator.FromHtml(colors[11]);
                    button913.BackColor = ColorTranslator.FromHtml(colors[12]);
                    button914.BackColor = ColorTranslator.FromHtml(colors[13]);
                    button915.BackColor = ColorTranslator.FromHtml(colors[14]);
                    button916.BackColor = ColorTranslator.FromHtml(colors[15]);
                    button917.BackColor = ColorTranslator.FromHtml(colors[16]);
                    button918.BackColor = ColorTranslator.FromHtml(colors[17]);
                    button919.BackColor = ColorTranslator.FromHtml(colors[18]);
                    button920.BackColor = ColorTranslator.FromHtml(colors[19]);
                    button921.BackColor = ColorTranslator.FromHtml(colors[20]);
                    button922.BackColor = ColorTranslator.FromHtml(colors[21]);
                    button923.BackColor = ColorTranslator.FromHtml(colors[22]);
                    button924.BackColor = ColorTranslator.FromHtml(colors[23]);
                    button925.BackColor = ColorTranslator.FromHtml(colors[24]);
                    button926.BackColor = ColorTranslator.FromHtml(colors[25]);
                    button927.BackColor = ColorTranslator.FromHtml(colors[26]);
                    button928.BackColor = ColorTranslator.FromHtml(colors[27]);
                    button929.BackColor = ColorTranslator.FromHtml(colors[28]);
                    button930.BackColor = ColorTranslator.FromHtml(colors[29]);
                    button931.BackColor = ColorTranslator.FromHtml(colors[30]);
                    button932.BackColor = ColorTranslator.FromHtml(colors[31]);
                    button933.BackColor = ColorTranslator.FromHtml(colors[32]);
                    button934.BackColor = ColorTranslator.FromHtml(colors[33]);
                    button935.BackColor = ColorTranslator.FromHtml(colors[34]);
                    button936.BackColor = ColorTranslator.FromHtml(colors[35]);
                    button937.BackColor = ColorTranslator.FromHtml(colors[36]);
                    button938.BackColor = ColorTranslator.FromHtml(colors[37]);
                    button939.BackColor = ColorTranslator.FromHtml(colors[38]);
                    button940.BackColor = ColorTranslator.FromHtml(colors[39]);
                    button941.BackColor = ColorTranslator.FromHtml(colors[40]);
                    button942.BackColor = ColorTranslator.FromHtml(colors[41]);
                    button943.BackColor = ColorTranslator.FromHtml(colors[42]);
                    button944.BackColor = ColorTranslator.FromHtml(colors[43]);
                    button945.BackColor = ColorTranslator.FromHtml(colors[44]);
                    button946.BackColor = ColorTranslator.FromHtml(colors[45]);
                    button947.BackColor = ColorTranslator.FromHtml(colors[46]);
                    button948.BackColor = ColorTranslator.FromHtml(colors[47]);
                    button949.BackColor = ColorTranslator.FromHtml(colors[48]);
                    button950.BackColor = ColorTranslator.FromHtml(colors[49]);
                    button951.BackColor = ColorTranslator.FromHtml(colors[50]);
                    button952.BackColor = ColorTranslator.FromHtml(colors[51]);
                    button953.BackColor = ColorTranslator.FromHtml(colors[52]);
                    button954.BackColor = ColorTranslator.FromHtml(colors[53]);
                    button955.BackColor = ColorTranslator.FromHtml(colors[54]);
                    button956.BackColor = ColorTranslator.FromHtml(colors[55]);
                    button957.BackColor = ColorTranslator.FromHtml(colors[56]);
                    button958.BackColor = ColorTranslator.FromHtml(colors[57]);
                    button959.BackColor = ColorTranslator.FromHtml(colors[58]);
                    button960.BackColor = ColorTranslator.FromHtml(colors[59]);
                    button961.BackColor = ColorTranslator.FromHtml(colors[60]);
                    button962.BackColor = ColorTranslator.FromHtml(colors[61]);
                    button963.BackColor = ColorTranslator.FromHtml(colors[62]);
                    button964.BackColor = ColorTranslator.FromHtml(colors[63]);
                    button965.BackColor = ColorTranslator.FromHtml(colors[64]);
                    button966.BackColor = ColorTranslator.FromHtml(colors[65]);
                    button967.BackColor = ColorTranslator.FromHtml(colors[66]);
                    button968.BackColor = ColorTranslator.FromHtml(colors[67]);
                    button969.BackColor = ColorTranslator.FromHtml(colors[68]);
                    button970.BackColor = ColorTranslator.FromHtml(colors[69]);
                    button971.BackColor = ColorTranslator.FromHtml(colors[70]);
                    button972.BackColor = ColorTranslator.FromHtml(colors[71]);
                    button973.BackColor = ColorTranslator.FromHtml(colors[72]);
                    button974.BackColor = ColorTranslator.FromHtml(colors[73]);
                    button975.BackColor = ColorTranslator.FromHtml(colors[74]);
                    button976.BackColor = ColorTranslator.FromHtml(colors[75]);
                    button977.BackColor = ColorTranslator.FromHtml(colors[76]);
                    button978.BackColor = ColorTranslator.FromHtml(colors[77]);
                    button979.BackColor = ColorTranslator.FromHtml(colors[78]);
                    button980.BackColor = ColorTranslator.FromHtml(colors[79]);
                    button981.BackColor = ColorTranslator.FromHtml(colors[80]);
                    button982.BackColor = ColorTranslator.FromHtml(colors[81]);
                    button983.BackColor = ColorTranslator.FromHtml(colors[82]);
                    button984.BackColor = ColorTranslator.FromHtml(colors[83]);
                    button985.BackColor = ColorTranslator.FromHtml(colors[84]);
                    button986.BackColor = ColorTranslator.FromHtml(colors[85]);
                    button987.BackColor = ColorTranslator.FromHtml(colors[86]);
                    button988.BackColor = ColorTranslator.FromHtml(colors[87]);
                    button989.BackColor = ColorTranslator.FromHtml(colors[88]);
                    button990.BackColor = ColorTranslator.FromHtml(colors[89]);
                    button991.BackColor = ColorTranslator.FromHtml(colors[90]);
                    button992.BackColor = ColorTranslator.FromHtml(colors[91]);
                    button993.BackColor = ColorTranslator.FromHtml(colors[92]);
                    button994.BackColor = ColorTranslator.FromHtml(colors[93]);
                    button995.BackColor = ColorTranslator.FromHtml(colors[94]);
                    button996.BackColor = ColorTranslator.FromHtml(colors[95]);
                    button997.BackColor = ColorTranslator.FromHtml(colors[96]);
                    button998.BackColor = ColorTranslator.FromHtml(colors[97]);
                    button999.BackColor = ColorTranslator.FromHtml(colors[98]);
                    button9100.BackColor = ColorTranslator.FromHtml(colors[99]);
                    button9101.BackColor = ColorTranslator.FromHtml(colors[100]);
                    button9102.BackColor = ColorTranslator.FromHtml(colors[101]);
                    button9103.BackColor = ColorTranslator.FromHtml(colors[102]);
                    button9104.BackColor = ColorTranslator.FromHtml(colors[103]);
                    button9105.BackColor = ColorTranslator.FromHtml(colors[104]);
                    button9106.BackColor = ColorTranslator.FromHtml(colors[105]);
                    button9107.BackColor = ColorTranslator.FromHtml(colors[106]);
                    button9108.BackColor = ColorTranslator.FromHtml(colors[107]);
                    button9109.BackColor = ColorTranslator.FromHtml(colors[108]);
                    button9110.BackColor = ColorTranslator.FromHtml(colors[109]);
                    button9111.BackColor = ColorTranslator.FromHtml(colors[110]);
                    button9112.BackColor = ColorTranslator.FromHtml(colors[111]);
                    button9113.BackColor = ColorTranslator.FromHtml(colors[112]);
                    button9114.BackColor = ColorTranslator.FromHtml(colors[113]);
                    button9115.BackColor = ColorTranslator.FromHtml(colors[114]);
                    button9116.BackColor = ColorTranslator.FromHtml(colors[115]);
                    button9117.BackColor = ColorTranslator.FromHtml(colors[116]);
                    button9118.BackColor = ColorTranslator.FromHtml(colors[117]);
                    button9119.BackColor = ColorTranslator.FromHtml(colors[118]);
                    button9120.BackColor = ColorTranslator.FromHtml(colors[119]);
                    button9121.BackColor = ColorTranslator.FromHtml(colors[120]);
                    button9122.BackColor = ColorTranslator.FromHtml(colors[121]);
                    button9123.BackColor = ColorTranslator.FromHtml(colors[122]);
                    button9124.BackColor = ColorTranslator.FromHtml(colors[123]);
                    button9125.BackColor = ColorTranslator.FromHtml(colors[124]);
                    button9126.BackColor = ColorTranslator.FromHtml(colors[125]);
                    button9127.BackColor = ColorTranslator.FromHtml(colors[124]);
                    button9128.BackColor = ColorTranslator.FromHtml(colors[123]);
                    button9129.BackColor = ColorTranslator.FromHtml(colors[122]);
                    button9130.BackColor = ColorTranslator.FromHtml(colors[121]);
                    button9131.BackColor = ColorTranslator.FromHtml(colors[120]);
                    button9132.BackColor = ColorTranslator.FromHtml(colors[119]);
                    button9133.BackColor = ColorTranslator.FromHtml(colors[118]);
                    button9134.BackColor = ColorTranslator.FromHtml(colors[117]);
                    button9135.BackColor = ColorTranslator.FromHtml(colors[116]);
                    button9136.BackColor = ColorTranslator.FromHtml(colors[115]);
                    button9137.BackColor = ColorTranslator.FromHtml(colors[114]);
                    button9138.BackColor = ColorTranslator.FromHtml(colors[113]);
                    button9139.BackColor = ColorTranslator.FromHtml(colors[112]);
                    button9140.BackColor = ColorTranslator.FromHtml(colors[111]);
                    button9141.BackColor = ColorTranslator.FromHtml(colors[110]);
                    button9142.BackColor = ColorTranslator.FromHtml(colors[109]);
                    button9143.BackColor = ColorTranslator.FromHtml(colors[108]);
                    button9144.BackColor = ColorTranslator.FromHtml(colors[107]);

                    random = r.Next(1, 145);

                    if (random == 1)
                    {
                        button901.BackColor = Color.Red;
                        Session["lastRedButton"] = "button901";
                    }
                    else if (random == 2)
                    {
                        button902.BackColor = Color.Red;
                        Session["lastRedButton"] = "button902";
                    }
                    else if (random == 3)
                    {
                        button903.BackColor = Color.Red;
                        Session["lastRedButton"] = "button903";
                    }
                    else if (random == 4)
                    {
                        button904.BackColor = Color.Red;
                        Session["lastRedButton"] = "button904";
                    }
                    else if (random == 5)
                    {
                        button905.BackColor = Color.Red;
                        Session["lastRedButton"] = "button905";
                    }
                    else if (random == 6)
                    {
                        button906.BackColor = Color.Red;
                        Session["lastRedButton"] = "button906";
                    }
                    else if (random == 7)
                    {
                        button907.BackColor = Color.Red;
                        Session["lastRedButton"] = "button907";
                    }
                    else if (random == 8)
                    {
                        button908.BackColor = Color.Red;
                        Session["lastRedButton"] = "button908";
                    }
                    else if (random == 9)
                    {
                        button909.BackColor = Color.Red;
                        Session["lastRedButton"] = "button909";
                    }
                    else if (random == 10)
                    {
                        button910.BackColor = Color.Red;
                        Session["lastRedButton"] = "button910";
                    }
                    else if (random == 11)
                    {
                        button911.BackColor = Color.Red;
                        Session["lastRedButton"] = "button911";
                    }
                    else if (random == 12)
                    {
                        button912.BackColor = Color.Red;
                        Session["lastRedButton"] = "button912";
                    }
                    else if (random == 13)
                    {
                        button913.BackColor = Color.Red;
                        Session["lastRedButton"] = "button913";
                    }
                    else if (random == 14)
                    {
                        button914.BackColor = Color.Red;
                        Session["lastRedButton"] = "button914";
                    }
                    else if (random == 15)
                    {
                        button915.BackColor = Color.Red;
                        Session["lastRedButton"] = "button915";
                    }
                    else if (random == 16)
                    {
                        button916.BackColor = Color.Red;
                        Session["lastRedButton"] = "button916";
                    }
                    else if (random == 17)
                    {
                        button917.BackColor = Color.Red;
                        Session["lastRedButton"] = "button917";
                    }
                    else if (random == 18)
                    {
                        button918.BackColor = Color.Red;
                        Session["lastRedButton"] = "button918";
                    }
                    else if (random == 19)
                    {
                        button919.BackColor = Color.Red;
                        Session["lastRedButton"] = "button919";
                    }
                    else if (random == 20)
                    {
                        button920.BackColor = Color.Red;
                        Session["lastRedButton"] = "button920";
                    }
                    else if (random == 21)
                    {
                        button921.BackColor = Color.Red;
                        Session["lastRedButton"] = "button921";
                    }
                    else if (random == 22)
                    {
                        button922.BackColor = Color.Red;
                        Session["lastRedButton"] = "button922";
                    }
                    else if (random == 23)
                    {
                        button923.BackColor = Color.Red;
                        Session["lastRedButton"] = "button923";
                    }
                    else if (random == 24)
                    {
                        button924.BackColor = Color.Red;
                        Session["lastRedButton"] = "button924";
                    }
                    else if (random == 25)
                    {
                        button925.BackColor = Color.Red;
                        Session["lastRedButton"] = "button925";
                    }
                    else if (random == 26)
                    {
                        button926.BackColor = Color.Red;
                        Session["lastRedButton"] = "button926";
                    }
                    else if (random == 27)
                    {
                        button927.BackColor = Color.Red;
                        Session["lastRedButton"] = "button927";
                    }
                    else if (random == 28)
                    {
                        button928.BackColor = Color.Red;
                        Session["lastRedButton"] = "button928";
                    }
                    else if (random == 29)
                    {
                        button929.BackColor = Color.Red;
                        Session["lastRedButton"] = "button929";
                    }
                    else if (random == 30)
                    {
                        button930.BackColor = Color.Red;
                        Session["lastRedButton"] = "button930";
                    }
                    else if (random == 31)
                    {
                        button931.BackColor = Color.Red;
                        Session["lastRedButton"] = "button931";
                    }
                    else if (random == 32)
                    {
                        button932.BackColor = Color.Red;
                        Session["lastRedButton"] = "button932";
                    }
                    else if (random == 33)
                    {
                        button933.BackColor = Color.Red;
                        Session["lastRedButton"] = "button933";
                    }
                    else if (random == 34)
                    {
                        button934.BackColor = Color.Red;
                        Session["lastRedButton"] = "button934";
                    }
                    else if (random == 35)
                    {
                        button935.BackColor = Color.Red;
                        Session["lastRedButton"] = "button935";
                    }
                    else if (random == 36)
                    {
                        button936.BackColor = Color.Red;
                        Session["lastRedButton"] = "button936";
                    }
                    else if (random == 37)
                    {
                        button937.BackColor = Color.Red;
                        Session["lastRedButton"] = "button937";
                    }
                    else if (random == 38)
                    {
                        button938.BackColor = Color.Red;
                        Session["lastRedButton"] = "button938";
                    }
                    else if (random == 39)
                    {
                        button939.BackColor = Color.Red;
                        Session["lastRedButton"] = "button939";
                    }
                    else if (random == 40)
                    {
                        button940.BackColor = Color.Red;
                        Session["lastRedButton"] = "button940";
                    }
                    else if (random == 41)
                    {
                        button941.BackColor = Color.Red;
                        Session["lastRedButton"] = "button941";
                    }
                    else if (random == 42)
                    {
                        button942.BackColor = Color.Red;
                        Session["lastRedButton"] = "button942";
                    }
                    else if (random == 43)
                    {
                        button943.BackColor = Color.Red;
                        Session["lastRedButton"] = "button943";
                    }
                    else if (random == 44)
                    {
                        button944.BackColor = Color.Red;
                        Session["lastRedButton"] = "button944";
                    }
                    else if (random == 45)
                    {
                        button945.BackColor = Color.Red;
                        Session["lastRedButton"] = "button945";
                    }
                    else if (random == 46)
                    {
                        button946.BackColor = Color.Red;
                        Session["lastRedButton"] = "button946";
                    }
                    else if (random == 47)
                    {
                        button947.BackColor = Color.Red;
                        Session["lastRedButton"] = "button947";
                    }
                    else if (random == 48)
                    {
                        button948.BackColor = Color.Red;
                        Session["lastRedButton"] = "button948";
                    }
                    else if (random == 49)
                    {
                        button949.BackColor = Color.Red;
                        Session["lastRedButton"] = "button949";
                    }
                    else if (random == 50)
                    {
                        button950.BackColor = Color.Red;
                        Session["lastRedButton"] = "button950";
                    }
                    else if (random == 51)
                    {
                        button951.BackColor = Color.Red;
                        Session["lastRedButton"] = "button951";
                    }
                    else if (random == 52)
                    {
                        button952.BackColor = Color.Red;
                        Session["lastRedButton"] = "button952";
                    }
                    else if (random == 53)
                    {
                        button953.BackColor = Color.Red;
                        Session["lastRedButton"] = "button953";
                    }
                    else if (random == 54)
                    {
                        button954.BackColor = Color.Red;
                        Session["lastRedButton"] = "button954";
                    }
                    else if (random == 55)
                    {
                        button955.BackColor = Color.Red;
                        Session["lastRedButton"] = "button955";
                    }
                    else if (random == 56)
                    {
                        button956.BackColor = Color.Red;
                        Session["lastRedButton"] = "button956";
                    }
                    else if (random == 57)
                    {
                        button957.BackColor = Color.Red;
                        Session["lastRedButton"] = "button957";
                    }
                    else if (random == 58)
                    {
                        button958.BackColor = Color.Red;
                        Session["lastRedButton"] = "button958";
                    }
                    else if (random == 59)
                    {
                        button959.BackColor = Color.Red;
                        Session["lastRedButton"] = "button959";
                    }
                    else if (random == 60)
                    {
                        button960.BackColor = Color.Red;
                        Session["lastRedButton"] = "button960";
                    }
                    else if (random == 61)
                    {
                        button961.BackColor = Color.Red;
                        Session["lastRedButton"] = "button961";
                    }
                    else if (random == 62)
                    {
                        button962.BackColor = Color.Red;
                        Session["lastRedButton"] = "button962";
                    }
                    else if (random == 63)
                    {
                        button963.BackColor = Color.Red;
                        Session["lastRedButton"] = "button963";
                    }
                    else if (random == 64)
                    {
                        button964.BackColor = Color.Red;
                        Session["lastRedButton"] = "button964";
                    }
                    else if (random == 65)
                    {
                        button965.BackColor = Color.Red;
                        Session["lastRedButton"] = "button965";
                    }
                    else if (random == 66)
                    {
                        button966.BackColor = Color.Red;
                        Session["lastRedButton"] = "button966";
                    }
                    else if (random == 67)
                    {
                        button967.BackColor = Color.Red;
                        Session["lastRedButton"] = "button967";
                    }
                    else if (random == 68)
                    {
                        button968.BackColor = Color.Red;
                        Session["lastRedButton"] = "button968";
                    }
                    else if (random == 69)
                    {
                        button969.BackColor = Color.Red;
                        Session["lastRedButton"] = "button969";
                    }
                    else if (random == 70)
                    {
                        button970.BackColor = Color.Red;
                        Session["lastRedButton"] = "button970";
                    }
                    else if (random == 71)
                    {
                        button971.BackColor = Color.Red;
                        Session["lastRedButton"] = "button971";
                    }
                    else if (random == 72)
                    {
                        button972.BackColor = Color.Red;
                        Session["lastRedButton"] = "button972";
                    }
                    else if (random == 73)
                    {
                        button973.BackColor = Color.Red;
                        Session["lastRedButton"] = "button973";
                    }
                    else if (random == 74)
                    {
                        button974.BackColor = Color.Red;
                        Session["lastRedButton"] = "button974";
                    }
                    else if (random == 75)
                    {
                        button975.BackColor = Color.Red;
                        Session["lastRedButton"] = "button975";
                    }
                    else if (random == 76)
                    {
                        button976.BackColor = Color.Red;
                        Session["lastRedButton"] = "button976";
                    }
                    else if (random == 77)
                    {
                        button977.BackColor = Color.Red;
                        Session["lastRedButton"] = "button977";
                    }
                    else if (random == 78)
                    {
                        button978.BackColor = Color.Red;
                        Session["lastRedButton"] = "button978";
                    }
                    else if (random == 79)
                    {
                        button979.BackColor = Color.Red;
                        Session["lastRedButton"] = "button979";
                    }
                    else if (random == 80)
                    {
                        button980.BackColor = Color.Red;
                        Session["lastRedButton"] = "button980";
                    }
                    else if (random == 81)
                    {
                        button981.BackColor = Color.Red;
                        Session["lastRedButton"] = "button981";
                    }
                    else if (random == 82)
                    {
                        button982.BackColor = Color.Red;
                        Session["lastRedButton"] = "button982";
                    }
                    else if (random == 83)
                    {
                        button983.BackColor = Color.Red;
                        Session["lastRedButton"] = "button983";
                    }
                    else if (random == 84)
                    {
                        button984.BackColor = Color.Red;
                        Session["lastRedButton"] = "button984";
                    }
                    else if (random == 85)
                    {
                        button985.BackColor = Color.Red;
                        Session["lastRedButton"] = "button985";
                    }
                    else if (random == 86)
                    {
                        button986.BackColor = Color.Red;
                        Session["lastRedButton"] = "button986";
                    }
                    else if (random == 87)
                    {
                        button987.BackColor = Color.Red;
                        Session["lastRedButton"] = "button987";
                    }
                    else if (random == 88)
                    {
                        button988.BackColor = Color.Red;
                        Session["lastRedButton"] = "button988";
                    }
                    else if (random == 89)
                    {
                        button989.BackColor = Color.Red;
                        Session["lastRedButton"] = "button989";
                    }
                    else if (random == 90)
                    {
                        button990.BackColor = Color.Red;
                        Session["lastRedButton"] = "button990";
                    }
                    else if (random == 91)
                    {
                        button991.BackColor = Color.Red;
                        Session["lastRedButton"] = "button991";
                    }
                    else if (random == 92)
                    {
                        button992.BackColor = Color.Red;
                        Session["lastRedButton"] = "button992";
                    }
                    else if (random == 93)
                    {
                        button993.BackColor = Color.Red;
                        Session["lastRedButton"] = "button993";
                    }
                    else if (random == 94)
                    {
                        button994.BackColor = Color.Red;
                        Session["lastRedButton"] = "button994";
                    }
                    else if (random == 95)
                    {
                        button995.BackColor = Color.Red;
                        Session["lastRedButton"] = "button995";
                    }
                    else if (random == 96)
                    {
                        button996.BackColor = Color.Red;
                        Session["lastRedButton"] = "button996";
                    }
                    else if (random == 97)
                    {
                        button997.BackColor = Color.Red;
                        Session["lastRedButton"] = "button997";
                    }
                    else if (random == 98)
                    {
                        button998.BackColor = Color.Red;
                        Session["lastRedButton"] = "button998";
                    }
                    else if (random == 99)
                    {
                        button999.BackColor = Color.Red;
                        Session["lastRedButton"] = "button999";
                    }
                    else if (random == 100)
                    {
                        button9100.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9100";
                    }
                    else if (random == 101)
                    {
                        button9101.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9101";
                    }
                    else if (random == 102)
                    {
                        button9102.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9102";
                    }
                    else if (random == 103)
                    {
                        button9103.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9103";
                    }
                    else if (random == 104)
                    {
                        button9104.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9104";
                    }
                    else if (random == 105)
                    {
                        button9105.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9105";
                    }
                    else if (random == 106)
                    {
                        button9106.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9106";
                    }
                    else if (random == 107)
                    {
                        button9107.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9107";
                    }
                    else if (random == 108)
                    {
                        button9108.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9108";
                    }
                    else if (random == 109)
                    {
                        button9109.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9109";
                    }
                    else if (random == 110)
                    {
                        button9110.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9110";
                    }
                    else if (random == 111)
                    {
                        button9111.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9111";
                    }
                    else if (random == 112)
                    {
                        button9112.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9112";
                    }
                    else if (random == 113)
                    {
                        button9113.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9113";
                    }
                    else if (random == 114)
                    {
                        button9114.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9114";
                    }
                    else if (random == 115)
                    {
                        button9115.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9115";
                    }
                    else if (random == 116)
                    {
                        button9116.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9116";
                    }
                    else if (random == 117)
                    {
                        button9117.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9117";
                    }
                    else if (random == 118)
                    {
                        button9118.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9118";
                    }
                    else if (random == 119)
                    {
                        button9119.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9119";
                    }
                    else if (random == 120)
                    {
                        button9120.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9120";
                    }
                    else if (random == 121)
                    {
                        button9121.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9121";
                    }
                    else if (random == 122)
                    {
                        button9122.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9122";
                    }
                    else if (random == 123)
                    {
                        button9123.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9123";
                    }
                    else if (random == 124)
                    {
                        button9124.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9124";
                    }
                    else if (random == 125)
                    {
                        button9125.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9125";
                    }
                    else if (random == 126)
                    {
                        button9126.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9126";
                    }
                    else if (random == 127)
                    {
                        button9127.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9127";
                    }
                    else if (random == 128)
                    {
                        button9128.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9128";
                    }
                    else if (random == 129)
                    {
                        button9129.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9129";
                    }
                    else if (random == 130)
                    {
                        button9130.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9130";
                    }
                    else if (random == 131)
                    {
                        button9131.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9131";
                    }
                    else if (random == 132)
                    {
                        button9132.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9132";
                    }
                    else if (random == 133)
                    {
                        button9133.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9133";
                    }
                    else if (random == 134)
                    {
                        button9134.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9134";
                    }
                    else if (random == 135)
                    {
                        button9135.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9135";
                    }
                    else if (random == 136)
                    {
                        button9136.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9136";
                    }
                    else if (random == 137)
                    {
                        button9137.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9137";
                    }
                    else if (random == 138)
                    {
                        button9138.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9138";
                    }
                    else if (random == 139)
                    {
                        button9139.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9139";
                    }
                    else if (random == 140)
                    {
                        button9140.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9140";
                    }
                    else if (random == 141)
                    {
                        button9141.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9141";
                    }
                    else if (random == 142)
                    {
                        button9142.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9142";
                    }
                    else if (random == 143)
                    {
                        button9143.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9143";
                    }
                    else
                    {
                        button9144.BackColor = Color.Red;
                        Session["lastRedButton"] = "button9144";
                    }

                    level8.Visible = false;
                    level9.Visible = true;
                    break;
                case 10:
                    if (btn.ID == Session["lastRedButton"].ToString())
                    {
                        score = Convert.ToInt32(Session["score"]);
                        score++;
                        Session["score"] = score;
                        lblYourScore.Text = Session["score"].ToString();
                        level8.Visible = false;
                        level9.Visible = true;
                        goto case 9;
                        //break;
                    }
                    else
                    {
                        level9.Visible = false;
                        level99.Visible = true;
                        lblYourScore.Text = Session["score"].ToString();
                        Session["score"] = 0;
                        break;
                    }

                case 100:
                    level99.Visible = false;
                    level0.Visible = true;
                    Session["lastRedButton"] = "button101";
                    Session["score"] = 0;
                    displayHighScores();
                    break;
                default:
                    break;
            }
            lblScore.Text = Session["score"].ToString();
        }

        protected void Shuffle<T>(T[] array)
        {
            Random _random = new Random();
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

        protected void btnSaveScore_Click(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("/files/highscore.txt");
            var jsonData = File.ReadAllText(filePath);
            var scoreList = JsonConvert.DeserializeObject<List<HighScore>>(jsonData) ?? new List<HighScore>();

            scoreList.Add(new HighScore()
                {
                    Name = tbInitial.Text, Score = Convert.ToInt32(lblYourScore.Text)
                });

            jsonData = JsonConvert.SerializeObject(scoreList);
            File.WriteAllText(filePath, jsonData);

            level99.Visible = false;
            level0.Visible = true;
            Session["lastRedButton"] = "button101";
            Session["score"] = 0;
            displayHighScores();
        }

        protected void displayHighScores()
        {
            //read high scores
            //display high scores top 10
            string filePath = Server.MapPath("/files/highscore.txt");
            var jsonData = File.ReadAllText(filePath);
            var scoreList = JsonConvert.DeserializeObject<List<HighScore>>(jsonData) ?? new List<HighScore>();

            List<HighScore> sortedList = scoreList.OrderBy(o => -1* o.Score).ToList();

            StringBuilder sbHighScores = new StringBuilder();

            foreach (HighScore a in sortedList)
            {
                sbHighScores.AppendLine(a.Name + ":" + a.Score);
                
            }

            lblHighScores.Text = sbHighScores.ToString().Replace(Environment.NewLine, "<br />");
        }
    }
}