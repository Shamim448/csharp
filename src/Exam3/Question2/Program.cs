// See https://aka.ms/new-console-template for more information
using Question2;
AlarmSender alarmSender = new AlarmSender();
alarmSender.OnAlarm += GetAlarm;
alarmSender.SendAlarm(8, "Good Morning");

void GetAlarm(int id, string msg)
{
    Console.WriteLine("The alarm id is:" + id);
    Console.WriteLine(msg);
}