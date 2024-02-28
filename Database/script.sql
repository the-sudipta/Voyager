create table Air_Table
(
    id  int(50) auto_increment
        primary key,
    air char(50) null
);

create table Bus_Table
(
    id  int(50) auto_increment
        primary key,
    bus char(50) null
);

create table Client_Table
(
    id          int(50) auto_increment
        primary key,
    name        char(50) null,
    phone       char(50) null,
    mail        char(50) null,
    nid         char(50) null,
    member      int(30)  null,
    date        char(30) null,
    destination char(50) null,
    transport   char(50) null
);

create table Destination_Table
(
    id          int(50) auto_increment
        primary key,
    destination char(50) null
);

create table Hotel_Table
(
    id    int(50) auto_increment
        primary key,
    hotel char(50) null
);

create table Message_Table
(
    id    int(50) auto_increment
        primary key,
    admin char(255) null,
    recep char(255) null
);

create table Staffs_Table
(
    id       int(50) auto_increment
        primary key,
    username char(30) null,
    password char(50) null,
    earnings char(30) null
);

create table Tour_Table
(
    id    int(50) auto_increment
        primary key,
    tours char(20) null
);

create table Train_Table
(
    id    int(50) auto_increment
        primary key,
    train char(50) null
);


