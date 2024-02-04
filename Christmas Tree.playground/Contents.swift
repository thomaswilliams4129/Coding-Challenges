import UIKit

// print out a Christmas Tree

//     *               1 + spaces = (5 * 2 = 10) = 11
//    ***              3 + spaces = (4 * 2 = 8) =  11
//   *****             5 + spaces = (3 * 2 = 6) =  11
//  *******            7 + spaces = (2 * 2 = 4) =  11
// *********           9 + spaces = (1 * 2 = 4) =  11
//***********          11 + spaces = (0 * 2 = 0) = 11
//
// ((height * 2 - 1) - star) /  2
// ((7 * 2 - 1) - star) / 2

func printChristmasTree(height: Int) {
    
    // num of stars
    var starCount = 1
    
    // number of stars in the base
    let maxColumns = height * 2 - 1
    
    // loop to print stars
    for i in 1...height {
        
        // number of spaces / 2
        // only need half to print in front of stars to space them
        let numOfSpaces = (maxColumns - starCount) / 2
        
        // create string of spaces
        let spaces = String(repeating: " ", count: numOfSpaces)
        // create string of stars
        let stars = String(repeating: "*", count: starCount)
        
        // print out the spaces + stars
        print("\(spaces)\(stars)")
        
        // increase starCount by 2 each time
        starCount += 2
    }
}

printChristmasTree(height: 7)
printChristmasTree(height: 13)
