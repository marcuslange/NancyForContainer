FROM microsoft/aspnet
COPY NancyForContainer\\bin\\Release \\NancyForContainer
RUN netsh http add urlacl url=http://+:8080/ user=Everyone
RUN /NancyForContainer/NancyForContainer install
RUN /NancyForContainer/NancyForContainer start