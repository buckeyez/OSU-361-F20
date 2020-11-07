<template>
  <transition name="modal--fade">
    <div v-show="active" class="modal">
      <slot />
    </div>
  </transition>
</template>

<script>
export default {
  props: {
    active: {
      type: Boolean,
      default: false,
    },
  },

  data() {
    return {
      callbackRegistered: false,
      escapeCallback: ev => {
        if (ev.key === 'Escape') {
          this.closeModal();
        }
      },
    };
  },

  mounted() {
    this.registerCallback();
  },

  beforeDestroy() {
    this.clearCallback();
  },

  methods: {
    closeModal() {
      this.$emit('update:active', false);
    },

    clearCallback() {
      if (this.callbackRegistered) {
        document.removeEventListener('keyup', this.escapeCallback);
        this.callbackRegistered = false;
      }
    },

    registerCallback() {
      if (!this.callbackRegistered) {
        document.addEventListener('keyup', this.escapeCallback);
        this.callbackRegistered = true;
      }
    },
  },
};
</script>

<style>
.modal {
  align-items: center;
  background-color: rgba(0, 0, 0, 0.86);
  bottom: 0;
  display: flex;
  justify-content: center;
  left: 0;
  overflow: hidden;
  position: absolute;
  right: 0;
  top: 0;
  z-index: 10;
}

.modal--fade-enter-active,
.modal--fade-leave-active {
  transition: opacity 0.3s ease-out;
}
.modal--fade-enter,
.modal--fade-leave-to {
  opacity: 0;
}
.modal--fade-enter-to,
.modal--fade-leave {
  opacity: 1;
}
</style>
