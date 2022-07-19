var mergeKLists = function(lists) {
    const merge = (l1, l2) => {
      if (!l1 || !l2) return l1 || l2;
      let node = {};
      const root = node;
      while (l1 && l2) {
        if (l1.val <= l2.val) {
          node.next = l1;
          l1 = l1.next;
        } else {
          node.next = l2;
          l2 = l2.next;
        }
        node = node.next;
      }
      if (l1) node.next = l1;
      if (l2) node.next = l2;
      return root.next;
    }
    
    let root = lists[0];
    for (let i = 1; i < lists.length; i++) {
      root = merge(root, lists[i]);
    }
    
    return root || null;
  };