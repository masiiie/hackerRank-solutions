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
  

  let rt = new Node();
  rt.isLeaf = topLeft.val == topRight.val && topLeft.val == bottomLeft.val && topLeft.val == bottomRight.val;
  if(rt.isLeaf) {
    rt.val = topLeft.val;
    rt.topLeft = null;
    rt.topRight = null;
    rt.bottomLeft = null;
    rt.bottomRight = null;
  } else {
    rt.val = 1;
    rt.topLeft = topLeft;
    rt.topRight = topRight;
    rt.bottomLeft = bottomLeft;
    rt.bottomRight = bottomRight;
  }

  return rt;
};