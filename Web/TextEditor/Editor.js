// Editor container 
var editor_element = document.querySelector('#editor-text');

// No of ranges
var num_ranges = window.getSelection().rangeCount;
   
// Will hold parent tags of a range    
var range_parent_tags;
    
// Will hold parent tags of all ranges
var all_ranges_parent_tags = [];

var start_element,
    end_element,
    cur_element,

// For all ranges
for(var i=0; i<num_ranges; i++) {
    // Start container of range
    start_element = window.getSelection().getRangeAt(i).startContainer;
    
    // End container of range
    end_element = window.getSelection().getRangeAt(i).endContainer;
    
    // Will hold parent tags of the range
    range_parent_tags = [];

    // If starting container and end container are the same
    if(start_element.isEqualNode(end_element)) {
        cur_element = start_element.parentNode;
        
        // Get all parent tags till editor container
        while(!editor_element.isEqualNode(cur_element)) {
            range_parent_tags.push(cur_element.nodeName);
            cur_element = cur_element.parentNode;
        }
    }

    // Push tags of current range 
    all_ranges_parent_tags.push(range_parent_tags);
}

// then select common tags from entries in "all_ranges_parent_tags"