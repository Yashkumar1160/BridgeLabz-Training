using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.appointment
{
    public interface IAppointment
    {
        //UC-3.1->Book New Appointment
        void BookAppointment();

        //UC-3.2->Check Doctor Availability
        void CheckDoctorAvailability();
        
        //UC-3.3->Cancel Appointment
        void CancelAppointment();
        
        //UC-3.4->Reschedule Appointment
        void RescheduleAppointment();

        //UC-3.5->View Daily Appointment Schedule        
        void ViewDailyAppointments();
    }
}