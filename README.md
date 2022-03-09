# IP CHANGER

Change IP address of your network adapter.

## Description

Change IP address by your costum names with IP, SUBNET and GATEWAY

## Getting Started

### Dependencies

* .NET framework 4
* log4net

### Installing

* Copy bin files to any directory and run ipchanger.exe
* Modify config file by adding or removing your preset selection of IP addresses

### Executing program

* Run ipchanger.exe
* All settings are done by applicationSettings and are binded
* Setting config file is in userdata folder, so each user will need to config application seperatly
```
code blocks for commands
```

## Help

Feel free to ask questions.
```
Config.ini file contains all custom selections
```
Open Config.ini file, copy paste SAMPLE preset as many as you need and edit by your needs.
```
Save Config.ini file and reload the file or restart application if you have selected to load config on startup.
```

[Info]
Name=IPChangerConfig
Version=1.00.000

[SAMPLE1]
IPADDRESS=192.168.10.10
SUBNET=255.255.255.0
GATEWAY=192.168.10.1

[SAMPLE2]
IPADDRESS=192.168.20.10
SUBNET=255.255.255.0
GATEWAY=192.168.20.1

[SAMPLE3]
IPADDRESS=192.168.30.10
SUBNET=255.255.255.0
GATEWAY=192.168.30.1

## Authors

Contributors names and contact info

ex. turbozob  
ex. [@turbozob](turbozob@live.com)

## Version History

* 0.2
    * Various bug fixes and optimizations
    * See [commit change]() or See [release history]()
* 0.1
    * Initial Release

## License

This project is licensed under the [NAME HERE] License - see the LICENSE.md file for details