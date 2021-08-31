using System;
using Xunit;
using ZhangM;
using Moq;
using System.ComponentModel;
using System.Linq;
using FluentAssertions;
using System.Collections.Generic;

namespace XUnitTest
{
    public class SystemRelationSectSubsidiaryTest
    {
        [Fact]
        public void Test()
        {

            var relationMgr = new RelationManager();
            var system = new SystemRelationSectSubsidiary(relationMgr);

            var sect1 = new Sect();
            var sect2 = new Sect();
            var sect3 = new Sect();

            var sub1 = new Subsidiary("111");
            var sub2 = new Subsidiary("222");
            var sub3 = new Subsidiary("333");

            system.SetRelation(sect1, sub1);

            sub1.sect.Should().Be(sect1);
            sect1.subsidiaries.Should().BeEquivalentTo(new Subsidiary[] { sub1 });
            sect2.subsidiaries.Should().BeEmpty();
            sect3.subsidiaries.Should().BeEmpty();

            system.SetRelation(sect1, sub2);

            sub1.sect.Should().Be(sect1);
            sub2.sect.Should().Be(sect1);
            sect1.subsidiaries.Should().BeEquivalentTo(new Subsidiary[] { sub1, sub2 });
            sect2.subsidiaries.Should().BeEmpty();
            sect3.subsidiaries.Should().BeEmpty();

            system.SetRelation(sect1, sub3);

            sub1.sect.Should().Be(sect1);
            sub2.sect.Should().Be(sect1);
            sub3.sect.Should().Be(sect1);
            sect1.subsidiaries.Should().BeEquivalentTo(new Subsidiary[] { sub1, sub2, sub3 });
            sect2.subsidiaries.Should().BeEmpty();
            sect3.subsidiaries.Should().BeEmpty();

            system.SetRelation(sect3, sub3);

            sub1.sect.Should().Be(sect1);
            sub2.sect.Should().Be(sect1);
            sub3.sect.Should().Be(sect3);
            sect1.subsidiaries.Should().BeEquivalentTo(new Subsidiary[] { sub1, sub2 });
            sect2.subsidiaries.Should().BeEmpty();
            sect3.subsidiaries.Should().BeEquivalentTo(new Subsidiary[] { sub3 });

            system.SetRelation(sect2, sub2);

            sub1.sect.Should().Be(sect1);
            sub2.sect.Should().Be(sect2);
            sub3.sect.Should().Be(sect3);
            sect1.subsidiaries.Should().BeEquivalentTo(new Subsidiary[] { sub1 });
            sect2.subsidiaries.Should().BeEquivalentTo(new Subsidiary[] { sub2 });
            sect3.subsidiaries.Should().BeEquivalentTo(new Subsidiary[] { sub3 });
        }
    }
}
