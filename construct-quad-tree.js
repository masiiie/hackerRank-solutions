/**
 * // Definition for a QuadTree node.
 * function Node(val,isLeaf,topLeft,topRight,bottomLeft,bottomRight) {
 *    this.val = val;
 *    this.isLeaf = isLeaf;
 *    this.topLeft = topLeft;
 *    this.topRight = topRight;
 *    this.bottomLeft = bottomLeft;
 *    this.bottomRight = bottomRight;
 * };
 */

/**
 * @param {number[][]} grid
 * @return {Node}
 */
var construct = function(grid) {
  if(grid.length == 1) return new Node(grid[0][0], true, null, null, null, null);

  let topLeft = [];
  let topRight = [];
  let bottomLeft = [];
  let bottomRight = [];

  for (let i = 0; i < grid.length; i++) {
    if(i < grid.length/2) {
        topLeft.push(grid[i].slice(0, grid.length/2));
        topRight.push(grid[i].slice(grid.length/2));
    } else {
        bottomLeft.push(grid[i].slice(0, grid.length/2));
        bottomRight.push(grid[i].slice(grid.length/2));
    }
  }

  topLeft = construct(topLeft);
  topRight = construct(topRight);
  bottomLeft = construct(bottomLeft);
  bottomRight = construct(bottomRight);

  let leaf = 
    topLeft.isLeaf && topRight.isLeaf && bottomLeft.isLeaf && bottomRight.isLeaf
    && topLeft.val == topRight.val 
    && topLeft.val == bottomLeft.val 
    && topLeft.val == bottomRight.val; 
  
  if(leaf) return new Node(topLeft.val, true, null, null, null, null);
  else return new Node(1, false, topLeft, topRight, bottomLeft, bottomRight);
};