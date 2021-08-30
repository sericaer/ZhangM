using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public class SystemManager
    {
        public readonly SystemRelationSubsidiaryBusiness systemRelationSubsidiaryBusiness;
        public readonly SystemRelationPersonSubsidiary systemRelationPersonSubsidiary;
        public readonly SystemRelationSectSubsidiary systemRelationSectSubsidiary;

        //public readonly SystemProductProcess systemProductProcess;
        //public readonly SystemRelationPersonSect systemRelationPersonSect;

        public SystemManager(RelationManager relationMgr)
        {
            systemRelationSubsidiaryBusiness = new SystemRelationSubsidiaryBusiness(relationMgr);
            systemRelationPersonSubsidiary = new SystemRelationPersonSubsidiary(relationMgr);
            systemRelationSectSubsidiary = new SystemRelationSectSubsidiary(relationMgr);

            //systemProductProcess = new SystemProductProcess();

            //systemRelationPersonSect = new SystemRelationPersonSect(relationMgr);
        }
    }
}
