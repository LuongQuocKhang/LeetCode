package string_easy

import (
	"fmt"
	"sort"
)

/***
* Tag: Easy
* Name: 2418. Sort the People
* Start Time: 27/07/2024 15:04 PM
* End Time: 27/07/2024 15:50 PM
* Result:
	* Runtime: solution 1: Beats 86.04% of users with Go ( 17ms )
	* Memory:  solution 1: Beats 16.97% of users with go ( 7.1MB )
***/

func Run() {
	names := []string{"Mary", "John", "Emma"}

	heights := []int{180, 165, 170}

	sorted := sortPeople(names, heights)

	for _, value := range sorted {
		fmt.Println(value)
	}
}

func sortPeople(names []string, heights []int) []string {
	var sorted []string
	mp := make(map[int]int)

	for i := range heights {
		mp[heights[i]] = i
	}

	sort.Ints(heights)

	for i := len(heights) - 1; i >= 0; i-- {
		sorted = append(sorted, names[mp[heights[i]]])
	}

	return sorted
}
