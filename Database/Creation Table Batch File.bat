@echo off
@echo Executing SQL Pharùa Table Creation Scripts
SQLCMD -s DESKTOP-3RKAS3I -d Pharma Proj -u PharmaLogin -p PharmaApp159 -i "D:\C# Projects\Medina Medix Pharma\Base de Données\SQL Query Pharma.sql"
PAUSE