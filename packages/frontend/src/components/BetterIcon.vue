<script setup lang="ts">
import { computed } from 'vue'

const props = defineProps({
  size: {
    type: String,
    default: 'md',
    validator: (value: string) => ['sm', 'md', 'lg', 'xl'].includes(value)
  },
  variant: {
    type: String,
    default: 'default',
    validator: (value: string) => ['default', 'primary', 'secondary', 'accent', 'ghost', 'info', 'success', 'warning', 'error'].includes(value)
  }
})

// Size mappings
const sizeClasses: Record<string, string> = {
  sm: 'w-8 h-8 text-sm',
  md: 'w-10 h-10 text-base',
  lg: 'w-12 h-12 text-lg',
  xl: 'w-14 h-14 text-xl'
}

// Variant mappings using DaisyUI colors
const variantClasses: Record<string, string> = {
  default: 'bg-base-200 text-base-content',
  primary: 'bg-primary/10 text-primary',
  secondary: 'bg-secondary-content/10 text-secondary-content',
  accent: 'bg-accent text-accent-content',
  ghost: 'bg-transparent text-current hover:bg-base-200',
  info: 'bg-info text-info-content',
  success: 'bg-success text-success-content',
  warning: 'bg-warning text-warning-content',
  error: 'bg-error text-error-content'
}

const classes = computed(() => {
  return [
    'inline-flex items-center justify-center rounded-full transition-colors',
    sizeClasses[props.size] || sizeClasses.md,
    variantClasses[props.variant] || variantClasses.default
  ]
})
</script>

<template>
  <div :class="classes">
    <slot />
  </div>
</template>
