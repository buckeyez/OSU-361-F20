<template>
  <div class="login-button" @click="$emit('click', $event)">
    <label>{{ text }}</label>
  </div>
</template>

<script>
export default {
  props: {
    text: {
      type: String,
      required: true,
    },
  },
};
</script>

<style>
.login-button {
  align-items: center;
  border: 0.125rem solid #fff;
  cursor: pointer;
  display: flex;
  font-size: 1.2rem;
  height: 2.5rem;
  justify-content: center;
  width: 7rem;
}

.login-button:hover {
  background-color: rgba(0, 0, 0, 0.4);
}

.login-button > label {
  cursor: pointer;
}
</style>
