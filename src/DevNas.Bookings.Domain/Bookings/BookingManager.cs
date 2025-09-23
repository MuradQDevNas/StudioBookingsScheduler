using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace DevNas.Bookings.Bookings
{
    public class BookingManager : DomainService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingManager(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<Booking> CreateAsync(Guid studioId, Guid teacherId, TimeRange timeRange)
        {
            // Rule 1: Prevent double booking
            var conflict = await _bookingRepository.AnyAsync(
                b => b.StudioId == studioId &&
                     b.Status == BookingStatus.Confirmed &&
                     b.TimeRange.Overlaps(timeRange)
            );

            if (conflict)
            {
                throw new BusinessException("A booking already exists for this time slot.");
            }

            var booking = new Booking(
                GuidGenerator.Create(),
                studioId,
                teacherId,
                timeRange
            );

            return booking;
        }

        public async Task CancelAsync(Booking booking, Guid requesterId, bool isAdmin = false)
        {
            if (booking.TeacherId != requesterId && !isAdmin)
            {
                throw new BusinessException("Only the booking owner or admin can cancel.");
            }

            booking.Cancel();
        }

        public void BlockAsync(Booking booking)
        {
            booking.BlockByAdmin();
        }

        public void ConfirmAsync(Booking booking)
        {
            booking.Confirm();
        }
    }

}
