API Web Application ASP.NET Core 3.1 Configure for HTTPS Enable Docker Support MySQL Server 8.0.11



Microsoft.EntityFrameworkCore (v5.0.5 – the latest stable version)
Microsoft.EntityFrameworkCore.Tools (v5.0.5 – the latest stable version)
Pomelo.EntityFrameworkCore.MySql (version 5.0.0)


127.0.0.1 111111 root 3306
MySQL 8.0 Command Line Client
how Databases;

IIS Express
https://localhost:44397/api/user


deploying failure
tools panel
docker 
PW>
Get-ExecutionPolicy
Set-ExecutionPolicy Unrestricted -Force

heroku login
docker ps -a

docker build -t counter-image-six-two -f Dockerfile .
docker create --name core-counter-six-two counter-image-six-two
docker ps -a

docker tag counter-image-six-two registry.heroku.com/appstory-my/web
heroku container:login
docker push registry.heroku.com/appstory-my/web
heroku container:release web -a=appstory-my

heroku logs --tail -a=appstory-my

Set-ExecutionPolicy Restricted -Force
