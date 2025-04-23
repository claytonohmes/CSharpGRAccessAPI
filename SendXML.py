import requests

#store the file contents of the xml file as a string
xml_file_path = 'YKF_CV_299_Bag.xml'
entity_name = xml_file_path.replace('.xml', '')
with open(xml_file_path, 'r') as file:
    xml_data = file.read()

data = {
    "entityName": entity_name,
    "xmlContent": xml_data,
}

# Define the URL to send the XML data to
url = "https://localhost:7121/api/xml/GetXML"

response = requests.post(url, json=data, verify='localhost.crt')

print(f"Response status code: {response.status_code}")
print(f"Response content: {response.content.decode('utf-8')}")
print(f"Response headers: {response.headers}")
print(f"Response text: {response.text}")
