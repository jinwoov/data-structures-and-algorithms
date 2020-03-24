using System;
using Xunit;
using LinkdList.Classes;

namespace LinkListXunit
{
    public class UnitTest1
    {
        [Fact]
        public void SuccessfullyInstantiateEmptyLinkList()
        {
            Linklist linkList = new Linklist();
            Assert.Null(linkList.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);

            Assert.Equal(3, ll.Head.Data);
        }

        [Fact]
        public void HeadPropertyPointingToFirstNode()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            Assert.Equal(2, ll.Head.Data);
        }

        [Fact]
        public void CanInsertMultipleNodeIntoLinkList()
        {
            Linklist ll = new Linklist();
            ll.Insert(4);
            ll.Insert(2);

            Node node = ll.Head.Next;


            Assert.Equal(4, node.Data);
        }

        [Fact]
        public void CanFindExistingNode()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            bool doesItHave = ll.Includes(4);

            Assert.True(doesItHave);
        }
        
        [Fact]
        public void CannnotFindNodeWhenNodeDoesntExist()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            bool doesItHave = ll.Includes(10);

            Assert.False(doesItHave);
        }

        [Fact]
        public void CanReturnAllofTheLinkList()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.ToString();
            string answer = "2 -> 4 -> 5 -> 3 -> NULL";

            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void AddingLinkListToEnd()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.Append(12);

            string answer = "2 -> 4 -> 5 -> 3 -> 12 -> NULL";

            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void AddingMultipleLinkToEndOfTheList()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.Append(101);
            ll.Append(401);

            string answer = "2 -> 4 -> 5 -> 3 -> 101 -> 401 -> NULL";
            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void CanAddBeforeTheMiddleOfTheLinkList()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.InsertBefore(5, 10);
            string answer = "2 -> 4 -> 10 -> 5 -> 3 -> NULL";
            
            Assert.Equal(answer, ll.ToString());
        }


        [Fact]
        public void CanAddBeforeTheFirstNodeInTheLinkList()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.InsertBefore(2, 102);
            string answer = "102 -> 2 -> 4 -> 5 -> 3 -> NULL";

            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void CanAddAfterMiddleOftheLinkList()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.InsertAfter(4, 21);
            string answer = "2 -> 4 -> 21 -> 5 -> 3 -> NULL";

            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void CanAddAfterLastNode()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.InsertAfter(3, 21);
            string answer = "2 -> 4 -> 5 -> 3 -> 21 -> NULL";

            Assert.Equal(answer, ll.ToString());
        }
    }
}