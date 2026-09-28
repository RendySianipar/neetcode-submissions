func hasDuplicate(nums []int) bool {
    
	n := len(nums)
	sort.Ints(nums)

	for i := 1; i < n; i++ {
		if nums[i-1] == nums[i] {
			return true
		}
	}

	return false
	

}
