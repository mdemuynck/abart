<template>
  <div class="inventory">
    <div class="item mb-4" v-for="item in items" :key="item.id">
      <button @click="orderItem(item)" class="px-4 py-2 bg-blue-500 text-white rounded w-full">
        {{ item.item_name }}
        <span v-if="orders[item.id]">{{ orders[item.id].amount }}</span>
      </button>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "inventoryList",
  data() {
    return {
      items: [],
      orders: [],
    };
  },
  created() {
    axios.get("http://localhost:5000/inventory").then((response) => {
      this.items = response.data;
    });
  },
  methods: {
    orderItem(item) {
      if (!this.orders[item.id]) {
        this.orders[item.id] = { amount: 1 };
      } else {
        this.orders[item.id].amount += 1;
      }
    },
  },
};
</script>
