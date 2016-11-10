from xml.dom import minidom


"""
Generate XML data
"""
doc = minidom.Document()

root = doc.createElement('Parameters_Table')
doc.appendChild(root)

for index in range(238): # set to the last defined parameter
	indexStr = str(index)
	parameter_element = doc.createElement('parameter')
	
	index_element = doc.createElement('index')
	index_node = doc.createTextNode(indexStr)
	index_element.appendChild(index_node)

	value_element = doc.createElement('value')
	value_node = doc.createTextNode(indexStr)
	value_element.appendChild(value_node)

	data_type_element = doc.createElement('datatype')
	# Currently, all indices are 'Float'.
	# Add 'elif' statements to define specific
	# data types for other indices
	if(index >= 0 and index <= 238):
		data_type_node = doc.createTextNode('Float')
	data_type_element.appendChild(data_type_node)
	
	parameter_element.appendChild(index_element)
	parameter_element.appendChild(value_element)
	parameter_element.appendChild(data_type_element)
	root.appendChild(parameter_element)

# root = doc.createElement('root')
# doc.appendChild(root)

# leaf = doc.createElement('leaf')
# text = doc.createTextNode('Text element with attributes')
# leaf.appendChild(text)
# leaf.setAttribute('color', 'white')
# root.appendChild(leaf)

"""
Generate XML file
""" 
xml_str = doc.toprettyxml(indent='  ')
with open('parameters_table.xml', 'w') as f:
    f.write(xml_str)