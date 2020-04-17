export DEBIAN_FRONTEND=noninteractive
#install tzdata package
sudo apt-get update
sudo apt-get install tzdata -y

sudo ln -fs /usr/share/zoneinfo/America/New_York /etc/localtime
sudo dpkg-reconfigure --frontend noninteractive tzdata