﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto) 
        {
            Booking booking = new Booking()
            {
                Mail=createBookingDto.Mail,
                Date=createBookingDto.Date,
                Name=createBookingDto.Name,
                PersonCount= createBookingDto.PersonCount,  
                Phone=createBookingDto.Phone
            };
           _bookingService.TAdd(booking);
            return Ok("Reservation has been cretaed.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values= _bookingService.TGetByID(id);
            _bookingService.TDelete(values);
            return Ok("Reservation has been deleted.");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDto.Mail,
                Date = updateBookingDto.Date,
                Name = updateBookingDto.Name,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone
            };
            _bookingService.TUpdate(booking);
            return Ok("The datas have been edited.");

        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            return Ok(values);
        }
    }
}
