create database frst_database
use frst_database   -- select specified database
use master
alter database [frst_database] modify name = [first_database]  -- rename database
drop database [first_database] -- delete database

backup database first_database to disk = 'F:\DotNet\DotNetProjects\Projects DATABASE\bk1.sql'