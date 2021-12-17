ftp.intel.com User Guide

Do you need to transfer a file to or from Intel?  Please read below and
if you are not an Intel Employee, then provide the information below to
your Intel contact.

 
*************** PLEASE READ *************************
NOTICE TO USERS: This is a private computer system and is the property of
Intel Corporation. It is for authorized use only. Users (authorized or 
unauthorized) have no explicit or implicit expectation of privacy. Any 
or all uses of this system and all files on system may be intercepted, 
monitored, recorded, copied, audited, inspected, and disclosed to 
authorized site, Intel Corporation, and law enforcement personnel, as well
as authorized officials of other agencies. By using this system, the user
consents to such interception, monitoring, recording, copying, auditing,
inspection, and disclosure at the discretion of authorized site or Intel
Corporation personnel. Unauthorized or improper use of this system may
result in administrative disciplinary action and civil and criminal
penalties. By continuing to use this system you indicate your awareness
of and consent to these terms and conditions of use. 

LOG OFF IMMEDIATELY
if you do not agree to the conditions stated in this warning.

**************************************************************************
*** Encrypt and compress all files before uploading them to the server
**************************************************************************

**************************************************************************
*** Who can I contact for help? ***
For issues please contact B2B.Tech.Support@intel.com
ftp.intel.com is supported Mon-Fri, 8am-5pm Pacific Time

************************************************************************** 
*** How To Get Access ***
Intel Employees can open http://goto.intel.com/ftp in a Web browser
and create a new FTP login id.  Users outside of Intel's network will not 
be able to access this link.

If you are not an Intel Employee, then please provide the above link to
your Intel contact.

See next section on how to login

**************************************************************************
*** How To Login ***
Configure FTP/s Client Software by creating a new site in your FTP's Client
Software using the information below:

Username: (refer to your login id created)
Password: (set when you create your login id)
Host Name:  secureftp.intel.com 
Server/Protocol Type:  FTP/SSL (AUTH_SSL, AUTH_TLS, or Explicit SSL/TLS) 
Mode:  Passive 
Port:  21 

**************************************************************************
*** How To Configure Your Firewall For Login ***
You may have a personal or company firewall that controls connections that
your system makes to other systems and may block these connections to
secureftp.intel.com

Intel users logging on to ftp.intel.com typically do not need to
configure a firewall.

ONLY IF applicable, configure your firewall configuration to allow 
TCP (FTP/SSL) communication to the Intel IP addresses and ports below:

Production System (destination)
IP Address: 192.198.164.123
Ports:  21, 36000 - 36200 

**************************************************************************
*** How To Configure Your Proxy Server ***
Your company's network may require you to configure a proxy server in your
FTP/s Client Software to be able to connect outside of your companies network.
Intel users connecting from an Intel network will not need to configure a
proxy service and can skip this step

If you are outside of Intel and are unable to connect to secureftp.intel.com
without doing this step, please contact your local IT support to determine
the correct proxy server configuration to use FTP on your company's network

**************************************************************************
*** FTP Client Software ***
FTP/s Client Software is designed to transfer files between a client and a
server computer over the network.  You will need FTP/s client software on the
system that you will use to transfer files. 

You may be familiar with FTP software that is available with Microsoft
Windows (sometimes referred to as ftp.exe).  Unfortunately, this ftp client
software is not compatible with this service as ftp.exe does not support
FTP/SSL.. 
 
**************************************************************************
*** Privacy Notice
https://www.intel.com/content/www/us/en/privacy/intel-privacy-notice.html
************************************************************************** 