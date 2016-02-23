FROM microsoft/aspnet
COPY NancyForContainer\\bin\\Release \\NancyForContainer
RUN netsh http delete urlacl url=http://+:8080/
RUN \\NancyForContainer\\NancyForContainer install
RUN \\NancyForContainer\\NancyForContainer start