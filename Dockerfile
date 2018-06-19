FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out
RUN apt-get update \
    && apt-get install -y --no-install-recommends openssh-server \
    && echo "root:Docker!" | chpasswd

 
EXPOSE 2222 8080 
# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/out .
WORKDIR /
    
COPY sshd_config /etc/ssh/
RUN pwd

COPY startup ../opt/startup
RUN cd /opt/startup
RUN chmod 755 /opt/startup/init_container.sh
WORKDIR /app

ENTRYPOINT ["dotnet", "HomeBase.dll","/opt/startup/init_container.sh"]