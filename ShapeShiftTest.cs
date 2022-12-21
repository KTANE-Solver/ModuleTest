using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using New_KTANE_Solver;
using System.Windows.Forms;
using System.IO;

namespace ModuleTests
{
    [TestClass]
    public class ShapeShiftTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        Bomb bomb = null;

        [TestMethod]
        public void TicketsInitialized()
        {
            ShapeShift module = new ShapeShift(bomb, streamWriter, ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Ticket);

            Assert.AreEqual(module.ticketList.Count, 16);

            Assert.IsTrue(module.ticketList[0].SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[0].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Point));
            Assert.IsTrue(module.ticketList[0].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Point));

            Assert.IsTrue(module.ticketList[1].SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Point));
            Assert.IsTrue(module.ticketList[1].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[1].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Flat));

            Assert.IsTrue(module.ticketList[2].SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[2].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Point));
            Assert.IsTrue(module.ticketList[2].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Round));

            Assert.IsTrue(module.ticketList[3].SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[3].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[3].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Round));

            Assert.IsTrue(module.ticketList[4].SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Point));
            Assert.IsTrue(module.ticketList[4].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[4].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Round));

            Assert.IsTrue(module.ticketList[5].SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Point));
            Assert.IsTrue(module.ticketList[5].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[5].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Flat));

            Assert.IsTrue(module.ticketList[6].SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[6].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[6].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Point));

            Assert.IsTrue(module.ticketList[7].SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[7].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Point));
            Assert.IsTrue(module.ticketList[7].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Flat));

            Assert.IsTrue(module.ticketList[8].SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[8].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[8].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Ticket));

            Assert.IsTrue(module.ticketList[9].SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[9].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[9].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Ticket));

            Assert.IsTrue(module.ticketList[10].SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[10].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[10].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Round));

            Assert.IsTrue(module.ticketList[11].SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[11].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[11].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Point));

            Assert.IsTrue(module.ticketList[12].SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[12].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[12].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Ticket));

            Assert.IsTrue(module.ticketList[13].SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[13].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Point));
            Assert.IsTrue(module.ticketList[13].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Flat));

            Assert.IsTrue(module.ticketList[14].SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[14].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[14].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Ticket));


            Assert.IsTrue(module.ticketList[15].SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Point));
            Assert.IsTrue(module.ticketList[15].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Point));
            Assert.IsTrue(module.ticketList[15].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Point, ShapeShift.TicketShape.Flat));
        }
    }
}
