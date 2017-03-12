using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensured.Tests
{
    using Shouldly;
    using System.Collections;
    using System.Collections.ObjectModel;

    public class EnsureCollectionTests
    {
        public void Collection_IsNotEmpty_should_pass_validation() {
            var collection = new List<int>();
            collection.Add(1);
            var sut = Ensure.That((ICollection)collection).IsNotEmpty();
            sut.Count.ShouldBe(1);
        }

        public void Collection_IsNotEmpty_should_throw_exception() {
            var collection = new List<int>();
            Should.Throw<Exception>(() => Ensure.That((ICollection)collection).IsNotEmpty());
        }

        public void CollectionT_IsNotEmpty_should_pass_validation() {
            var collection = new List<int>();
            collection.Add(1);
            var sut = Ensure.That((ICollection<int>)collection).IsNotEmpty();
            sut.Count.ShouldBe(1);
        }

        public void CollectionT_IsNotEmpty_should_throw_exception() {
            var collection = new List<int>();
            Should.Throw<Exception>(() => Ensure.That((ICollection<int>)collection).IsNotEmpty());
        }

        public void Collection_CountIs_should_pass_validation() {
            var collection = new List<int>();
            var sut = Ensure.That((ICollection)collection).CountIs(0);
            sut.Count.ShouldBe(0);
        }

        public void Collection_CountIs_should_throw_exception() {
            var collection = new List<int>();
            Should.Throw<Exception>(() => Ensure.That((ICollection)collection).CountIs(1));
        }

        public void CollectionT_CountIs_should_pass_validation() {
            var collection = new List<int>();
            var sut = Ensure.That((ICollection<int>)collection).CountIs(0);
            sut.Count.ShouldBe(0);
        }

        public void CollectionT_CountIs_should_throw_exception() {
            var collection = new List<int>();
            Should.Throw<Exception>(() => Ensure.That((ICollection<int>)collection).CountIs(1));
        }

        public void CollectionT_Contains_should_pass_validation() {
            var collection = new List<int>();
            collection.Add(1);
            var sut = Ensure.That((ICollection<int>)collection).Contains(1);
            sut.ShouldNotBeNull();
        }

        public void CollectionT_Contains_should_throw_exception() {
            var collection = new List<int>();
            Should.Throw<Exception>(() => Ensure.That((ICollection<int>)collection).Contains(1));
        }

    }
}
