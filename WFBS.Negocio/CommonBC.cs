using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBS.DALC;
using System.Data;

namespace WFBS.Negocio
{
    public class CommonBC
    {
        private static DALC.WFBSEntities _modeloWfbs;

        public static DALC.WFBSEntities ModeloWFBS
        {
            get
            {
                if (_modeloWfbs == null)
                {
                    _modeloWfbs = new WFBS.DALC.WFBSEntities();
                }
                return _modeloWfbs;
            }
        }

        public CommonBC()
        {
        }
    }
}
