/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/29/2022 7:03:53 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_ACCOUNT') and o.name = 'FK_TB_ACCOU_OWNS_TB_CUSTO')
alter table TB_ACCOUNT
   drop constraint FK_TB_ACCOU_OWNS_TB_CUSTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_BRANCH') and o.name = 'FK_TB_BRANC_HAS_TB_BANK')
alter table TB_BRANCH
   drop constraint FK_TB_BRANC_HAS_TB_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_CUSTOMER') and o.name = 'FK_TB_CUSTO_DEAL_TB_BRANC')
alter table TB_CUSTOMER
   drop constraint FK_TB_CUSTO_DEAL_TB_BRANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_EMPLOYEE') and o.name = 'FK_TB_EMPLO_WORKS_FOR_TB_BRANC')
alter table TB_EMPLOYEE
   drop constraint FK_TB_EMPLO_WORKS_FOR_TB_BRANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_LOAN') and o.name = 'FK_TB_LOAN_AVAILED_B_TB_ACCOU')
alter table TB_LOAN
   drop constraint FK_TB_LOAN_AVAILED_B_TB_ACCOU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_LOAN') and o.name = 'FK_TB_LOAN_MANAGE_TB_EMPLO')
alter table TB_LOAN
   drop constraint FK_TB_LOAN_MANAGE_TB_EMPLO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_LOAN') and o.name = 'FK_TB_LOAN_OFFER_TB_BRANC')
alter table TB_LOAN
   drop constraint FK_TB_LOAN_OFFER_TB_BRANC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_ACCOUNT')
            and   name  = 'OWNS_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_ACCOUNT.OWNS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_ACCOUNT')
            and   type = 'U')
   drop table TB_ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_ADMIN')
            and   type = 'U')
   drop table TB_ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_BANK')
            and   type = 'U')
   drop table TB_BANK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_BRANCH')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_BRANCH.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_BRANCH')
            and   type = 'U')
   drop table TB_BRANCH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_CUSTOMER')
            and   name  = 'DEAL_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_CUSTOMER.DEAL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_CUSTOMER')
            and   type = 'U')
   drop table TB_CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_EMPLOYEE')
            and   name  = 'WORKS_FOR_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_EMPLOYEE.WORKS_FOR_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_EMPLOYEE')
            and   type = 'U')
   drop table TB_EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_LOAN')
            and   name  = 'MANAGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_LOAN.MANAGE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_LOAN')
            and   name  = 'AVAILED_BY_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_LOAN.AVAILED_BY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_LOAN')
            and   name  = 'OFFER_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_LOAN.OFFER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_LOAN')
            and   type = 'U')
   drop table TB_LOAN
go

/*==============================================================*/
/* Table: TB_ACCOUNT                                            */
/*==============================================================*/
create table TB_ACCOUNT (
   ACCOUNT_NUMBER       int identity(1,1)    not null,
   SSN                  int                  not null,
   BALANCE              int                  null,
   TYPE                 varchar(50)          null,
   constraint PK_TB_ACCOUNT primary key nonclustered (ACCOUNT_NUMBER)
)
go

/*==============================================================*/
/* Index: OWNS_FK                                               */
/*==============================================================*/
create index OWNS_FK on TB_ACCOUNT (
SSN ASC
)
go

/*==============================================================*/
/* Table: TB_ADMIN                                              */
/*==============================================================*/
create table TB_ADMIN (
   USERNAME             char(10)             null,
   PASS                 char(10)             not null,
   constraint PK_TB_ADMIN primary key nonclustered (PASS)
)
go

/*==============================================================*/
/* Table: TB_BANK                                               */
/*==============================================================*/
create table TB_BANK (
	CODE                 int   identity(1,1) not null,
   NAME                 varchar(50)          null,
   ADDRESS              varchar(50)          null,
   constraint PK_TB_BANK primary key nonclustered (CODE)
)
go

/*==============================================================*/
/* Table: TB_BRANCH                                             */
/*==============================================================*/
create table TB_BRANCH (
	BRANCH_NUMBER        int  identity(1,1)   not null,
	CODE                 int                  null,
	ADDRESS              varchar(50)          null,
   
   
   constraint PK_TB_BRANCH primary key nonclustered (BRANCH_NUMBER)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on TB_BRANCH (
CODE ASC
)
go

/*==============================================================*/
/* Table: TB_CUSTOMER                                           */
/*==============================================================*/
create table TB_CUSTOMER (
   SSN                  int                  not null,
   BRANCH_NUMBER        int                  null,
   ADDRESS              varchar(50)          null,
   NAME                 varchar(50)          null,
   PHONE                numeric(11)          null,
   SSN_EMPLOYEE			int					 null,
   constraint PK_TB_CUSTOMER primary key nonclustered (SSN)
)
go

/*==============================================================*/
/* Index: DEAL_FK                                               */
/*==============================================================*/
create index DEAL_FK on TB_CUSTOMER (
BRANCH_NUMBER ASC
)
go

/*==============================================================*/
/* Table: TB_EMPLOYEE                                           */
/*==============================================================*/
create table TB_EMPLOYEE (
   SSN_EMPLOYEE         int                  not null,
   BRANCH_NUMBER        int                  not null,
   NAME                 varchar(50)          null,
   ADDRESS              varchar(50)          null,
   POSTION_             varchar(50)          null,
   PHONE                numeric(11)          null,
   constraint PK_TB_EMPLOYEE primary key nonclustered (SSN_EMPLOYEE)
)
go

/*==============================================================*/
/* Index: WORKS_FOR_FK                                          */
/*==============================================================*/
create index WORKS_FOR_FK on TB_EMPLOYEE (
BRANCH_NUMBER ASC
)
go

/*==============================================================*/
/* Table: TB_LOAN                                               */
/*==============================================================*/
create table TB_LOAN (
   LOAN_NUMBER          int                  not null,
   SSN_EMPLOYEE         int                  null,
   BRANCH_NUMBER        int                  null,
   ACCOUNT_NUMBER       int                  null,
   LOAN_AMOUNT          int                  null,
   LOAN_TYPE            varchar(50)          null,
   LOAN_STATUS			varchar(50)	DEFAULT 'Pending'		 null,
   constraint PK_TB_LOAN primary key nonclustered (LOAN_NUMBER)
)
go

/*==============================================================*/
/* Index: OFFER_FK                                              */
/*==============================================================*/
create index OFFER_FK on TB_LOAN (
BRANCH_NUMBER ASC
)
go

/*==============================================================*/
/* Index: AVAILED_BY_FK                                         */
/*==============================================================*/
create index AVAILED_BY_FK on TB_LOAN (
ACCOUNT_NUMBER ASC
)
go

/*==============================================================*/
/* Index: MANAGE_FK                                             */
/*==============================================================*/
create index MANAGE_FK on TB_LOAN (
SSN_EMPLOYEE ASC
)
go

alter table TB_ACCOUNT
   add constraint FK_TB_ACCOU_OWNS_TB_CUSTO foreign key (SSN)
      references TB_CUSTOMER (SSN)
         on delete cascade
go

alter table TB_BRANCH
   add constraint FK_TB_BRANC_HAS_TB_BANK foreign key (CODE)
      references TB_BANK (CODE)
         on delete cascade
go

alter table TB_CUSTOMER
   add constraint FK_TB_CUSTO_DEAL_TB_BRANC foreign key (BRANCH_NUMBER)
      references TB_BRANCH (BRANCH_NUMBER)
         on delete cascade
go

alter table TB_EMPLOYEE
   add constraint FK_TB_EMPLO_WORKS_FOR_TB_BRANC foreign key (BRANCH_NUMBER)
      references TB_BRANCH (BRANCH_NUMBER)
         on delete cascade
go

alter table TB_LOAN
   add constraint FK_TB_LOAN_AVAILED_B_TB_ACCOU foreign key (ACCOUNT_NUMBER)
      references TB_ACCOUNT (ACCOUNT_NUMBER)
         on delete cascade
go

alter table TB_LOAN
   add constraint FK_TB_LOAN_MANAGE_TB_EMPLO foreign key (SSN_EMPLOYEE)
      references TB_EMPLOYEE (SSN_EMPLOYEE)
         
go

alter table TB_LOAN
   add constraint FK_TB_LOAN_OFFER_TB_BRANC foreign key (BRANCH_NUMBER)
      references TB_BRANCH (BRANCH_NUMBER)
         
go

alter table TB_CUSTOMER
   add constraint FK_TB_EMP_ENTER_TB_CUST foreign key (SSN_EMPLOYEE)
      references TB_EMPLOYEE([SSN_EMPLOYEE])
         
go

