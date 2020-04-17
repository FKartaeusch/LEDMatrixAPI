export DEBIAN_FRONTEND=noninteractive
#install tzdata package
apt-get update
apt-get install tzdata -y

ln -fs /usr/share/zoneinfo/America/New_York /etc/localtime
dpkg-reconfigure --frontend noninteractive tzdata