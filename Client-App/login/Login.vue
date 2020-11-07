<template>
  <div class="login">
    <input v-model="userName" type="text" placeholder="Username" />
    <input type="password" placeholder="Password" />

    <section>
      <LoginButton text="Cancel" @click="$emit('cancel')" />
      <LoginButton text="Sign Up" @click="$emit('sign-up')" />
      <LoginButton text="Login" @click="$emit('login', userName)" />
    </section>
  </div>
</template>

<script>
import LoginButton from './LoginButton.vue';

export default {
  components: {
    LoginButton,
  },

  data() {
    return {
      userName: '',
    };
  },
};
</script>

<style>
.login {
  background-color: #444;
  border: 0.125rem solid #fff;
  border-radius: 0.5rem;
  display: flex;
  flex-direction: column;
  height: 25vh;
  justify-content: space-between;
  padding: 2rem;
  width: 30vw;
}

.login > section {
  align-items: flex-end;
  display: flex;
  height: 30%;
  justify-content: flex-end;
}

.login > section > div:first-child {
  margin-right: auto;
}

.login > section > div:last-child {
  margin-left: 0.5rem;
}
</style>
