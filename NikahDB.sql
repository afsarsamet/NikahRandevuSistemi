create database NikahRandevuDB
use NikahRandevuDB

create table users (
userID int primary key identity(1,1),
TC char(11) unique NOT NULL,
Ad varchar(25) NOT NULL,
Soyad varchar(25) NOT NULL,
email varchar(100) unique NOT NULL,
telefon varchar(11) unique NOT NULL,
cinsiyet char(1) NOT NULL,
Sifre varchar(256) NOT NULL,
KayitTarihi datetime default getdate()
)

create table personel (
prID int primary key identity(500,6),
TC char(11) unique NOT NULL,
Ad varchar(25) NOT NULL,
Soyad varchar(25) NOT NULL,
Email varchar(100) unique not null,
telefon varchar(11) unique not null,
sifre varchar(256),
aktifMi bit,
KayitTarihi datetime default getdate()
)

create table salonlar (
SalonID int primary key identity(5700,1),
SalonAdi varchar(100),
Durum bit
)

create table saatSlotlari (
SlotID int primary key identity(9,1),
saat time
)


create table randevular (
RandevuID int primary key identity(982,18),
userID int foreign key references users(userID),
GelinTC char(11) unique not null,
GelinAdSoyad varchar(100) not null,
DamatTC char(11) unique not null,
DamatAdSoyad varchar(100),
Sahit1TC char(11) unique not null,
Sahit1AdSoyad varchar(100) not null,
Sahit2TC char(11) not null unique,
Sahit2AdSoyad varchar(100) not null,
Tarih date,
Saat time,
salonID int foreign key references salonlar(SalonID),
OlusturmaTarihi datetime default getdate(),
Durum varchar(20),
IptalEdenPrID int NULL foreign key references personel(prID),
IptalTarihi datetime NULL
)

insert into personel (TC,Ad,Soyad,Email,sifre,telefon,aktifMi) 
values ('11112222333','Gorevli','Memur','gorevlimemur@admin.com','MemurNikah57','05244535874',1)

insert into personel (TC,Ad,Soyad,Email,sifre,telefon,aktifMi) 
values ('15124521531','Samet','Afþar','samet@admin.com','SametNikah67','05395626277',1)

insert into personel (TC,Ad,Soyad,Email,sifre,telefon,aktifMi) 
values ('14785134564','Arda','Tulum','arda@admin.com','ArdaNikah55','05426575134',0)

insert into personel (TC,Ad,Soyad,Email,sifre,telefon,aktifMi) 
values ('52135661554','Berkant','Kýlýç','berkant@admin.com','BerkantNikah42','05456356712',1)

ALTER TABLE users ADD dogumTarihi DATE

ALTER TABLE randevular ADD GelinDogumTarihi DATE,DamatDogumTarihi DATE