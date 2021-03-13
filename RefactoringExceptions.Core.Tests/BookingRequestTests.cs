using NUnit.Framework;
using System;
using NSubstitute;

namespace RefactoringExceptions.Core.Tests
{
    public class BookingRequestTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void When_the_date_is_missing_then_an_ArgumentNullException_is_thrown()
        {
            TodayDate today = Substitute.For<Today>();
            today.Date.Returns(DateTime.Parse("1111-01-01"));

            SimpleBookingRequest bookingRequest = new SimpleBookingRequest("1",null);

;           Assert.Throws(typeof(ArgumentNullException), () => bookingRequest.Check(today));
        }

        [Test]
        public void When_the_date_is_in_wrong_format_then_an_ArgumentOutOfRangeException_is_thrown()
        {
            TodayDate today = Substitute.For<Today>();
            today.Date.Returns(DateTime.Parse("1111-01-01"));

            SimpleBookingRequest bookingRequest = new SimpleBookingRequest("1", "wrong_format_date");

            Assert.Throws(typeof(ArgumentOutOfRangeException), () => bookingRequest.Check(today));
        }

        [Test]
        public void When_the_booking_date_is_before_today_date_then_an_ArgumentOutOfRangeException_is_thrown()
        {
            TodayDate today = Substitute.For<Today>();
            today.Date.Returns(DateTime.Parse("2222-01-01"));

            SimpleBookingRequest bookingRequest = new SimpleBookingRequest(numberOfSeats:"1", bookingDate:"1111-01-01");

            Assert.Throws(typeof(ArgumentOutOfRangeException), () => bookingRequest.Check(today));
        }

        [Test]
        public void When_the_number_of_seats_is_null_then_an_ArgumentNullException_is_thrown()
        {
            TodayDate today = Substitute.For<Today>();
            today.Date.Returns(DateTime.Parse("1111-01-01"));

            SimpleBookingRequest bookingRequest = new SimpleBookingRequest(numberOfSeats:string.Empty, bookingDate:"2222-01-01");

            Assert.Throws(typeof(ArgumentOutOfRangeException), () => bookingRequest.Check(today));
        }

        [TestCase("-1")]
        [TestCase("0")]
        public void When_the_number_of_seats_is_not_positive_then_an_ArgumentOutOfRangeException_is_thrown(string seatsNumber)
        {
            TodayDate today = Substitute.For<Today>();
            today.Date.Returns(DateTime.Parse("1111-01-01"));

            SimpleBookingRequest bookingRequest = new SimpleBookingRequest(seatsNumber, bookingDate:"2222-01-01");

            Assert.Throws(typeof(ArgumentOutOfRangeException), () => bookingRequest.Check(today));
        }
    }
}