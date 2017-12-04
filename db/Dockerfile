# Base OS layer: Latest Ubuntu LTS + mssql-server-linux (SQL Server engine + tools)
FROM microsoft/mssql-server-linux:2017-CU1

# Install curl since it is needed to get repo config
# Get official Microsoft repository configuration
RUN export DEBIAN_FRONTEND=noninteractive && \
    apt-get update && \
    apt-get install -y curl  && \
    curl https://packages.microsoft.com/keys/microsoft.asc | apt-key add - && \
    curl https://packages.microsoft.com/config/ubuntu/16.04/mssql-server-2017.list | tee /etc/apt/sources.list.d/mssql-server-2017.list && \
    apt-get update

# Install full text search package
RUN apt-get install -y mssql-server-fts

# Run SQL Server process with accepted EULA and as Developer Edition
ENV ACCEPT_EULA=Y
ENV MSSQL_PID=Developer
CMD /opt/mssql/bin/sqlservr