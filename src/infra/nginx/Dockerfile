FROM nginx

RUN DEBIAN_FRONTEND=noninteractive \
    apt-get update -qq && \
    apt-get -y install wget runit unzip && \
    rm -rf /var/lib/apt/lists/*

# vim - debug purposes
RUN apt-get update && apt-get -y install vim
RUN wget https://hashicorp-releases.mcs.mail.ru/consul-template/0.33.0/consul-template_0.33.0_linux_amd64.zip
# install consul-template
RUN unzip -d /usr/local/bin consul-template_0.33.0_linux_amd64.zip && rm consul-template_0.33.0_linux_amd64.zip

ADD nginx.service /etc/service/nginx/run
ADD consul-template.service /etc/service/consul-template/run

RUN mkdir /etc/consul-template && chmod +x /etc/service/nginx/run && chmod +x /etc/service/consul-template/run

CMD ["/usr/bin/runsvdir", "/etc/service"]
