using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZhangM
{
    class RunData
    {
        public PersonManager personMgr;
        public BusinessManager businessMgr;
        public SectManager sectMgr;
        public RelationManager relationMgr;
        public ProductManager productMgr;

        public SystemManager systemMgr;

        public RunData()
        {
            personMgr = new PersonManager();
            businessMgr = new BusinessManager();
            sectMgr = new SectManager();
            relationMgr = new RelationManager();
            systemMgr = new SystemManager(relationMgr);
            productMgr = new ProductManager();

            personMgr.Build();
            businessMgr.Build();
            sectMgr.build();

            var subsidiary = new Subsidiary("1111");

            systemMgr.systemRelationSectSubsidiary.SetRelation(sectMgr.First(), subsidiary);
            systemMgr.systemRelationSubsidiaryBusiness.SetRelation(subsidiary, businessMgr.First());
            systemMgr.systemRelationPersonSubsidiary.SetRelation(personMgr.First(), subsidiary);
        }
    }

}
