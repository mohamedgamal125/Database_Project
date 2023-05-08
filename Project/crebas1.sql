/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/27/2022 10:58:15 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMIN') and o.name = 'FK_ADMIN_UPDATES_A_PRODUCT')
alter table ADMIN
   drop constraint FK_ADMIN_UPDATES_A_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"BROWSE"') and o.name = 'FK_BROWSE_BROWSE_PRODUCT')
alter table "BROWSE"
   drop constraint FK_BROWSE_BROWSE_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"BROWSE"') and o.name = 'FK_BROWSE_BROWSE2_CUSTOMER')
alter table "BROWSE"
   drop constraint FK_BROWSE_BROWSE2_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BUY') and o.name = 'FK_BUY_RELATIONS_PRODUCT')
alter table BUY
   drop constraint FK_BUY_RELATIONS_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BUY') and o.name = 'FK_BUY_RELATIONS_CUSTOMER')
alter table BUY
   drop constraint FK_BUY_RELATIONS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_RELATIONS_SIGN_UP')
alter table CUSTOMER
   drop constraint FK_CUSTOMER_RELATIONS_SIGN_UP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_REMOVE_ADMIN')
alter table CUSTOMER
   drop constraint FK_CUSTOMER_REMOVE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_REMOVES_CUSTOMER')
alter table CUSTOMER
   drop constraint FK_CUSTOMER_REMOVES_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_SIGN_UP_CUSTOMER')
alter table CUSTOMER
   drop constraint FK_CUSTOMER_SIGN_UP_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_UPDATE_CUSTOMER')
alter table CUSTOMER
   drop constraint FK_CUSTOMER_UPDATE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCT') and o.name = 'FK_PRODUCT_BROWS_ADMIN')
alter table PRODUCT
   drop constraint FK_PRODUCT_BROWS_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SIGN_UP') and o.name = 'FK_SIGN_UP_RELATIONS_ADMIN')
alter table SIGN_UP
   drop constraint FK_SIGN_UP_RELATIONS_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SIGN_UP') and o.name = 'FK_SIGN_UP_RELATIONS_CUSTOMER')
alter table SIGN_UP
   drop constraint FK_SIGN_UP_RELATIONS_CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMIN')
            and   name  = 'UPDATES_ADD_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMIN.UPDATES_ADD_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"BROWSE"')
            and   name  = 'BROWSE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index "BROWSE".BROWSE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"BROWSE"')
            and   name  = 'BROWSE_FK'
            and   indid > 0
            and   indid < 255)
   drop index "BROWSE".BROWSE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"BROWSE"')
            and   type = 'U')
   drop table "BROWSE"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BUY')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index BUY.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BUY')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index BUY.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BUY')
            and   type = 'U')
   drop table BUY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUSTOMER')
            and   name  = 'UPDATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMER.UPDATE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUSTOMER')
            and   name  = 'SIGN_UP_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMER.SIGN_UP_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUSTOMER')
            and   name  = 'REMOVES_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMER.REMOVES_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUSTOMER')
            and   name  = 'RELATIONSHIP_10_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMER.RELATIONSHIP_10_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUSTOMER')
            and   name  = 'REMOVE_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMER.REMOVE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRODUCT')
            and   name  = 'BROWS_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRODUCT.BROWS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCT')
            and   type = 'U')
   drop table PRODUCT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SIGN_UP')
            and   name  = 'RELATIONSHIP_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index SIGN_UP.RELATIONSHIP_9_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SIGN_UP')
            and   type = 'U')
   drop table SIGN_UP
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ADMIN_NAME           varchar(1024)        not null,
   ADMIN_ID             int                  not null,
   P_ID                 int                  not null,
   constraint PK_ADMIN primary key nonclustered (ADMIN_ID)
)
go

/*==============================================================*/
/* Index: UPDATES_ADD_FK                                        */
/*==============================================================*/
create index UPDATES_ADD_FK on ADMIN (
P_ID ASC
)
go

/*==============================================================*/
/* Table: "BROWSE"                                              */
/*==============================================================*/
create table "BROWSE" (
   P_ID                 int                  not null,
   C_ID                 int                  not null,
   constraint PK_BROWSE primary key (P_ID, C_ID)
)
go

/*==============================================================*/
/* Index: BROWSE_FK                                             */
/*==============================================================*/
create index BROWSE_FK on "BROWSE" (
P_ID ASC
)
go

/*==============================================================*/
/* Index: BROWSE2_FK                                            */
/*==============================================================*/
create index BROWSE2_FK on "BROWSE" (
C_ID ASC
)
go

/*==============================================================*/
/* Table: BUY                                                   */
/*==============================================================*/
create table BUY (
   P_ID                 int                  not null,
   C_ID                 int                  not null,
   TOTAL_PRICE          decimal              not null,
   QUANTITY             int                  not null,
   P_DATE               timestamp            not null,
   constraint PK_BUY primary key (P_ID, C_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on BUY (
P_ID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on BUY (
C_ID ASC
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   F_NAME               varchar(10)          not null,
   L_NAME               varchar(10)          not null,
   C_ID                 int                  not null,
   CUS_C_ID             int                  null,
   CUS_C_ID2            int                  null,
   CUS_C_ID3            int                  null,
   ADMIN_ID             int                  null,
   SIG_ADMIN_ID         int                  null,
   C_ADDRES             varchar(50)          not null,
   PURCHASES            varchar(1024)        not null,
   PURCHASES_NUM        int                  not null,
   LAST_PURCHAS         timestamp            not null,
   constraint PK_CUSTOMER primary key nonclustered (C_ID)
)
go

/*==============================================================*/
/* Index: REMOVE_FK                                             */
/*==============================================================*/
create index REMOVE_FK on CUSTOMER (
ADMIN_ID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_10_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_10_FK on CUSTOMER (
SIG_ADMIN_ID ASC
)
go

/*==============================================================*/
/* Index: REMOVES_FK                                            */
/*==============================================================*/
create index REMOVES_FK on CUSTOMER (
CUS_C_ID3 ASC
)
go

/*==============================================================*/
/* Index: SIGN_UP_FK                                            */
/*==============================================================*/
create index SIGN_UP_FK on CUSTOMER (
CUS_C_ID ASC
)
go

/*==============================================================*/
/* Index: UPDATE_FK                                             */
/*==============================================================*/
create index UPDATE_FK on CUSTOMER (
CUS_C_ID2 ASC
)
go

/*==============================================================*/
/* Table: PRODUCT                                               */
/*==============================================================*/
create table PRODUCT (
   P_ID                 int                  not null,
   ADMIN_ID             int                  null,
   P_NAME               varchar(30)          not null,
   P_PRICE              int                  not null,
   SELLS                int                  null,
   TYPE                 varchar(1024)        null,
   NUMBER_OF_CUST       int                  null,
   constraint PK_PRODUCT primary key nonclustered (P_ID)
)
go

/*==============================================================*/
/* Index: BROWS_FK                                              */
/*==============================================================*/
create index BROWS_FK on PRODUCT (
ADMIN_ID ASC
)
go

/*==============================================================*/
/* Table: SIGN_UP                                               */
/*==============================================================*/
create table SIGN_UP (
   ADMIN_ID             int                  not null,
   C_ID                 int                  not null,
   USERNAME             varchar(1024)        not null,
   PASSWORD             numeric              not null,
   ADDRESS              varchar(1024)        not null,
   PHONE_NUM            numeric              not null,
   constraint PK_SIGN_UP primary key (ADMIN_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_9_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_9_FK on SIGN_UP (
C_ID ASC
)
go

alter table ADMIN
   add constraint FK_ADMIN_UPDATES_A_PRODUCT foreign key (P_ID)
      references PRODUCT (P_ID)
go

alter table "BROWSE"
   add constraint FK_BROWSE_BROWSE_PRODUCT foreign key (P_ID)
      references PRODUCT (P_ID)
go

alter table "BROWSE"
   add constraint FK_BROWSE_BROWSE2_CUSTOMER foreign key (C_ID)
      references CUSTOMER (C_ID)
go

alter table BUY
   add constraint FK_BUY_RELATIONS_PRODUCT foreign key (P_ID)
      references PRODUCT (P_ID)
go

alter table BUY
   add constraint FK_BUY_RELATIONS_CUSTOMER foreign key (C_ID)
      references CUSTOMER (C_ID)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_RELATIONS_SIGN_UP foreign key (SIG_ADMIN_ID)
      references SIGN_UP (ADMIN_ID)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_REMOVE_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_REMOVES_CUSTOMER foreign key (CUS_C_ID3)
      references CUSTOMER (C_ID)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_SIGN_UP_CUSTOMER foreign key (CUS_C_ID)
      references CUSTOMER (C_ID)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_UPDATE_CUSTOMER foreign key (CUS_C_ID2)
      references CUSTOMER (C_ID)
go

alter table PRODUCT
   add constraint FK_PRODUCT_BROWS_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table SIGN_UP
   add constraint FK_SIGN_UP_RELATIONS_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table SIGN_UP
   add constraint FK_SIGN_UP_RELATIONS_CUSTOMER foreign key (C_ID)
      references CUSTOMER (C_ID)
go

