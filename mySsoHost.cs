
using DigitalPlatform.Interfaces;
using DigitalPlatform.OPAC.Server;
using DigitalPlatform.Text;
using DigitalPlatform.Xml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace cbpmsso
{
    public class mySsoHost : ExternalSsoHost
    {
        OpacApplication app = null;
        SessionInfo sessioninfo = null;

        // parameters:
        //      strGotoUrl  如果函数返回-1，并且本参数不为空，则需要redirect到这个URL
        //      strError    [out]返回错误字符串
        // return:
        //      -1  出错
        //      0   不具备SSO条件。宿主会继续向后寻找其他接口
        //      1   成功
        public override int GetUserInfo(
            System.Web.UI.Page page,
            out string strLoginName,
            out string strSsoPageUrl,
            out string strError)
        {
            strError = "";
            strLoginName = "";
            strSsoPageUrl = "";

            app = (OpacApplication)page.Application["app"];
            sessioninfo = (SessionInfo)page.Session["sessioninfo"];

            strLoginName = "123456";
            return 1;
        }



    }
}
