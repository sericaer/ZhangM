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
    public class SystemRelationPersonSubsidiaryTest
    {
        [Fact]
        public void Test()
        {

            var relationMgr = new RelationManager();
            var system = new SystemRelationPersonSubsidiary(relationMgr);

            var p1 = new Person();
            var p2 = new Person();
            var p3 = new Person();

            var s1 = new Subsidiary();
            var s2 = new Subsidiary();
            var s3 = new Subsidiary();

            system.SetRelation(p1, s1);

            s1.owner.Should().Be(p1);
            s2.owner.Should().BeNull();
            s3.owner.Should().BeNull();
            p1.ownedSubsidiary.Should().Be(s1);
            p2.ownedSubsidiary.Should().BeNull();
            p3.ownedSubsidiary.Should().BeNull();

            system.SetRelation(p1, s2);

            s1.owner.Should().BeNull();
            s2.owner.Should().Be(p1);
            s3.owner.Should().BeNull();
            p1.ownedSubsidiary.Should().Be(s2);
            p2.ownedSubsidiary.Should().BeNull();
            p3.ownedSubsidiary.Should().BeNull();

            system.SetRelation(p1, s3);

            s1.owner.Should().BeNull();
            s2.owner.Should().BeNull();
            s3.owner.Should().Be(p1);
            p1.ownedSubsidiary.Should().Be(s3);
            p2.ownedSubsidiary.Should().BeNull();
            p3.ownedSubsidiary.Should().BeNull();

            system.SetRelation(p3, s3);

            s1.owner.Should().BeNull();
            s2.owner.Should().BeNull();
            s3.owner.Should().Be(p3);
            p1.ownedSubsidiary.Should().BeNull();
            p2.ownedSubsidiary.Should().BeNull();
            p3.ownedSubsidiary.Should().Be(s3);

            system.SetRelation(p2, s2);

            s1.owner.Should().BeNull();
            s2.owner.Should().Be(p2);
            s3.owner.Should().Be(p3);
            p1.ownedSubsidiary.Should().BeNull();
            p2.ownedSubsidiary.Should().Be(s2);
            p3.ownedSubsidiary.Should().Be(s3);

            system.SetRelation(null, s3);

            s1.owner.Should().BeNull();
            s2.owner.Should().Be(p2);
            s3.owner.Should().BeNull();
            p1.ownedSubsidiary.Should().BeNull();
            p2.ownedSubsidiary.Should().Be(s2);
            p3.ownedSubsidiary.Should().BeNull();

            system.SetRelation(p2, null);

            s1.owner.Should().BeNull();
            s2.owner.Should().BeNull();
            s3.owner.Should().BeNull();
            p1.ownedSubsidiary.Should().BeNull();
            p2.ownedSubsidiary.Should().BeNull();
            p3.ownedSubsidiary.Should().BeNull();
        }
    }
}
