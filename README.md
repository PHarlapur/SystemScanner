# SystemScanner

System scanner is a simple tool to scan automatically number of UNIX/LINUX systems and provide the output of command expressed in the XML.

Refer the sample data.xml file for format of the input data.


<systems>
	<unix>
		<ip>104.211.200.221</ip>
		<username>AzureUser</username>
		<password>Password@123</password>
		<command>exec ifconfig</command>
		<Results>1</Results>
	</unix>
	<unix>
		<ip>104.211.229.172</ip>
		<username>AzureUser</username>
		<password>Password@123</password>
		<command>exec ifconfig</command>
		<Results>2</Results>
	</unix>
</systems>
