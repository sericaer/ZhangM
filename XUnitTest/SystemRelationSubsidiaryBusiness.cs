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
    public class SystemRelationSubsidiaryBusinessTest
    {
        [Fact]
        public void Test()
        {

            var relationMgr = new RelationManager();
            var system = new SystemRelationSubsidiaryBusiness(relationMgr);

            var s1 = new Subsidiary();
            var s2 = new Subsidiary();
            var s3 = new Subsidiary();

            var b1 = new Business();
            var b2 = new Business();
            var b3 = new Business();

            system.SetRelation(s1, b1);

            b1.subsidiary.Should().Be(s1);
            s1.businesses.Should().BeEquivalentTo(new Business[] { b1 });
            s2.businesses.Should().BeEmpty();
            s3.businesses.Should().BeEmpty();

            system.SetRelation(s1, b2);

            b1.subsidiary.Should().Be(s1);
            b2.subsidiary.Should().Be(s1);
            s1.businesses.Should().BeEquivalentTo(new Business[] { b1, b2 });
            s2.businesses.Should().BeEmpty();
            s3.businesses.Should().BeEmpty();

            system.SetRelation(s1, b3);

            b1.subsidiary.Should().Be(s1);
            b2.subsidiary.Should().Be(s1);
            b3.subsidiary.Should().Be(s1);
            s1.businesses.Should().BeEquivalentTo(new Business[] { b1, b2, b3 });
            s2.businesses.Should().BeEmpty();
            s3.businesses.Should().BeEmpty();

            system.SetRelation(s3, b3);

            b1.subsidiary.Should().Be(s1);
            b2.subsidiary.Should().Be(s1);
            b3.subsidiary.Should().Be(s3);
            s1.businesses.Should().BeEquivalentTo(new Business[] { b1, b2 });
            s2.businesses.Should().BeEmpty();
            s3.businesses.Should().BeEquivalentTo(new Business[] { b3 });

            system.SetRelation(s2, b2);

            b1.subsidiary.Should().Be(s1);
            b2.subsidiary.Should().Be(s2);
            b3.subsidiary.Should().Be(s3);
            s1.businesses.Should().BeEquivalentTo(new Business[] { b1 });
            s2.businesses.Should().BeEquivalentTo(new Business[] { b2 });
            s3.businesses.Should().BeEquivalentTo(new Business[] { b3 });

            system.SetRelation(null, b1);

            b1.subsidiary.Should().Be(null);
            b2.subsidiary.Should().Be(s2);
            b3.subsidiary.Should().Be(s3);
            s1.businesses.Should().BeEmpty();
            s2.businesses.Should().BeEquivalentTo(new Business[] { b2 });
            s3.businesses.Should().BeEquivalentTo(new Business[] { b3 });
        }
    }
}
