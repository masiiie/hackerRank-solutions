const pathSum = (root, targetSum) => {
	let output = 0;
	let map = {};

	const traverse = (root, pathSum) => {
		if (!root) return null;

		pathSum += root.val; // current path sum

		// Case 1: starts from root node
		if (pathSum === targetSum) output++;

		// Case 2: starts from middle of tree
		// frequency of targetSum in the current path (up to current node)
		if (map[pathSum - targetSum]) output += map[pathSum - targetSum];

		// memoize current path sum (root to current node) and it's frequency
		if (map[pathSum]) map[pathSum]++;
		else map[pathSum] = 1;

		if (root.left) traverse(root.left, pathSum);
		if (root.right) traverse(root.right, pathSum);

		// remove the current path sum
		// to note that path is not available/visited
		map[pathSum]--;
	};

	traverse(root, 0);
	return output;
};