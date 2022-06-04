create database weatherforecast;
use weatherforecast;

create table WeatherForecast (
	Id int identity primary key,
	TemperatureC int not null,
	Date datetime not null,
	Summary varchar(100) null
)

